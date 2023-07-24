Imports System.Runtime.InteropServices
Imports System.IO

Public Class Form1
    <DllImport("library.dll", SetLastError:=True, CharSet:=CharSet.Ansi)>
    Private Shared Function interop_process_webp(src_filename As String, target_filename As String) As Integer
    End Function

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lsbFileList_KeyDown(sender As Object, e As KeyEventArgs) Handles lsbFileList.KeyDown
        If e.KeyCode = Keys.Delete Then
            If lsbFileList.SelectedItem <> Nothing Then
                lsbFileList.Items.Remove(lsbFileList.SelectedItem)
                CheckListItemCount()
            End If
        End If
    End Sub

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim filenames As String() = e.Data.GetData(DataFormats.FileDrop)

        Dim skipped%

        For Each nom In filenames
            ' Debug.WriteLine(Path.GetExtension(nom).ToLower())

            If lsbFileList.Items.Contains(nom) Or Path.GetExtension(nom).ToLower <> ".webp" Then
                skipped += 1
                Continue For
            End If

            lsbFileList.Items.Add(nom)
        Next

        If skipped > 0 Then
            MessageBox.Show($"Skipped {skipped} files due to either already added or not have WEBP extension.")
        End If

        CheckListItemCount()
    End Sub

    Const folder_name$ = "converted"
    Sub CheckConversionFolder()
        If Not Directory.Exists(folder_name) Then Directory.CreateDirectory(folder_name)
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim s As Stopwatch = New Stopwatch
        s.Start()

        CheckConversionFolder()

        ' Requires library.dll
        For Each filename In lsbFileList.Items
            Dim target = $"{folder_name}\{Path.GetFileNameWithoutExtension(filename)}.png"
            interop_process_webp(filename, target)
        Next

        s.Stop()

        txbLog.Text += $"Done in {s.Elapsed.TotalSeconds:#.##} s" & vbCrLf

        If MessageBox.Show("Clear list?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ClearList()
        End If
    End Sub

    Sub CheckListItemCount()
        lblHint.Visible = Not lsbFileList.Items.Count > 0
    End Sub

    Sub ClearList()
        lsbFileList.Items.Clear()
        CheckListItemCount()
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        If MessageBox.Show("Really?", "Clear list", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ClearList()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        CheckConversionFolder()
        Process.Start(folder_name)
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        If Not File.Exists("log.txt") Then
            MsgBox("Doesn't exist")
            Exit Sub
        End If

        Process.Start("log.txt")
    End Sub
End Class
