Imports OfficeOpenXml
Public Class Form1

    Private Sub chkWorkplaceHazards_CheckedChanged(sender As Object, e As EventArgs) Handles chkReportHazards.CheckedChanged
        Nextbtn.Enabled = chkReportHazards.Checked
        Finishbtn.Enabled = Not chkReportHazards.Checked
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        Dim nextForm As New Form2()
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles Finishbtn.Click

        MessageBox.Show("Data saved. Thank you!")
        Me.Close()
    End Sub

End Class

