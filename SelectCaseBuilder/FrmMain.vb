Imports System.Text.RegularExpressions

Public Class FrmMain

#Region "Variables"
    Dim files As String()
    Dim elseIndex As Integer = -1
#End Region

#Region "Load from textbox"
    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        LoadFromTextbox()
    End Sub

    Private Sub TxtFilesPath_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtFilesPath.KeyUp
        If e.KeyCode = Keys.Return Then
            LoadFromTextbox()
        End If
    End Sub

    Private Sub LoadFromTextbox()
        If IO.Directory.Exists(TxtFilesPath.Text) Then
            ' continue
            files = IO.Directory.GetFiles(TxtFilesPath.Text)
            LsvResources_Fill()
        Else
            ' error
            MessageBox.Show("Directory could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region

#Region "LsvResources"
    Private Sub LsvResources_Fill()
        TxtEditRef.Text = String.Empty
        TxtEditRes.Text = String.Empty

        LsvResources.Items.Clear()
        LsvResources.BeginUpdate()
        Dim fileMatch As Match
        For Each file As String In files
            fileMatch = Regex.Match(file, "[^\\]+\.[^\\]+$")
            If fileMatch.Success Then
                LsvResources.Items.Add(fileMatch.Value)
                LsvResources.Items(IndexMax).SubItems.Add(String.Empty)
                LsvResources.Items(IndexMax).SubItems.Add(String.Empty)
            End If
        Next
        LsvResources.EndUpdate()

        files = {String.Empty}
    End Sub

    Private Sub LsvResources_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvResources.SelectedIndexChanged
        If HasItemSelected() Then
            TxtEditRes.Text = SelectedResource
            TxtEditRef.Text = SelectedReference
        End If
    End Sub

    Private Sub LsvResources_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LsvResources.MouseDoubleClick
        If HasItemSelected() Then
            If SelectedIndex = elseIndex Then
                ' deselect
                LsvResources.Items(elseIndex).SubItems(2).Text = String.Empty
                elseIndex = -1
            Else
                ' select
                If elseIndex >= 0 Then LsvResources.Items(elseIndex).SubItems(2).Text = String.Empty
                LsvResources.SelectedItems(0).SubItems(2).Text = "✓"
                elseIndex = SelectedIndex
            End If
        End If
    End Sub

    Private Sub LsvResources_MouseClick(sender As Object, e As MouseEventArgs) Handles LsvResources.MouseClick
        TxtEditRef.Select()
    End Sub
#End Region

#Region "LsvResources item helper"
    Property SelectedResource As String
        Get
            Return LsvResources.SelectedItems(0).Text
        End Get
        Set(value As String)
            LsvResources.SelectedItems(0).Text = value
        End Set
    End Property

    Property SelectedReference As String
        Get
            Return LsvResources.SelectedItems(0).SubItems(1).Text
        End Get
        Set(value As String)
            LsvResources.SelectedItems(0).SubItems(1).Text = value
        End Set
    End Property

    Property SelectedIndex As Integer
        Get
            Return LsvResources.SelectedIndices(0)
        End Get
        Set(value As Integer)
            LsvResources.Items(value).Selected = True
        End Set
    End Property

    ReadOnly Property IndexCount As Integer
        Get
            Return LsvResources.Items.Count
        End Get
    End Property

    ReadOnly Property IndexMax As Integer
        Get
            Return LsvResources.Items.Count - 1
        End Get
    End Property

    Function HasItemSelected() As Boolean
        Return LsvResources.SelectedIndices.Count > 0
    End Function
#End Region

#Region "Edit"
    Private Sub TxtEditRef_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtEditRef.KeyUp
        If e.KeyCode = Keys.Return AndAlso IndexCount > 0 Then
            SelectedReference = TxtEditRef.Text
            If SelectedIndex < IndexMax Then
                SelectedIndex += 1
            End If
        ElseIf e.Alt And e.KeyCode = Keys.Up AndAlso SelectedIndex > 0 Then
            SelectedIndex -= 1
        ElseIf e.Alt And e.KeyCode = Keys.Down AndAlso SelectedIndex < IndexMax - 1 Then
            SelectedIndex += 1
        End If
    End Sub
#End Region

#Region "Output"
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If DlgSave.ShowDialog = DialogResult.OK Then
            Dim dlgInput As String = DlgSave.TxtInput.Text
            Dim output As String = "Select Case " & dlgInput

            For Each lsvItem As ListViewItem In LsvResources.Items
                If lsvItem.SubItems(1).Text IsNot String.Empty And lsvItem.SubItems(2).Text = String.Empty Then
                    output &= $"{vbNewLine}Case ""{lsvItem.SubItems(1).Text}""{vbNewLine}Return My.Resources.{FormatFilename(lsvItem.Text)}"
                End If
            Next
            If elseIndex >= 0 Then
                output &= $"{vbNewLine}Case Else{vbNewLine}Return My.Resources.{FormatFilename(LsvResources.Items(elseIndex).Text)}"
            End If
            output &= vbNewLine & "End Select"

            My.Computer.Clipboard.SetText(output)

            MessageBox.Show("Generated code saved to clipboard.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function FormatFilename(fileName As String)
        fileName = Regex.Match(fileName, "^[^.]+").Value ' remove file extension
        fileName = fileName.Replace("-", "_")
        Return fileName
    End Function
#End Region

#Region "Help screen"
    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        PnlHelp.BringToFront()
        PnlHelp.Visible = True
    End Sub

    Private Sub BtnCloseHelp_Click(sender As Object, e As EventArgs) Handles BtnCloseHelp.Click
        PnlHelp.Visible = False
    End Sub
#End Region

#Region "File drop"
    Private Sub PnlMain_DragEnter(sender As Object, e As DragEventArgs) Handles PnlMain.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub PnlMain_DragDrop(sender As Object, e As DragEventArgs) Handles PnlMain.DragDrop
        files = e.Data.GetData("FileDrop")
        If files.Count = 1 AndAlso IO.Directory.Exists(files(0)) Then
            TxtFilesPath.Text = files(0)
            files = IO.Directory.GetFiles(files(0))
        End If
        LsvResources_Fill()
    End Sub
#End Region

End Class