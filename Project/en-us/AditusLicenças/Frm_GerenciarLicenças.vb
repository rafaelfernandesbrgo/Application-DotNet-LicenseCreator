Imports System.Data.SqlClient



Public Class Frm_ManageLicenses


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button5.Click


		Dim dataStep1 As String
		Dim dataStep2 As String
		Dim dataStep3 As String

		Try

			''1st step
			dataStep1 = tx_D_Key1.Text & tx_D_Key2.Text & tx_D_Key3.Text & tx_D_Key4.Text

			''2nd step
			dataStep2 = dataStep1(0) & dataStep1(1) & dataStep1(2) & dataStep1(5) & dataStep1(6) & dataStep1(7) & dataStep1(10) & dataStep1(11) & dataStep1(12) & dataStep1(15) & dataStep1(16) & dataStep1(17)

			''3rd step
			dataStep3 = ""
			Dim alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
			Dim number As String = "0123456789"
			Dim i As String = 0
			Dim J As String = 0
			While i < 12
				While J < 10
					If dataStep2(i) = alphabet(J) Then
						dataStep3 = dataStep3 & number(J)
					End If
					J = J + 1
				End While
				i = i + 1
				J = 0
			End While

			''4th step
			tx_D_End.Text = dataStep3(7) & dataStep3(2) & "/" & dataStep3(5) & dataStep3(0) & "/" & dataStep3(9) & dataStep3(1)
			tx_D_Beginning.Text = dataStep3(3) & dataStep3(10) & "/" & dataStep3(11) & dataStep3(4) & "/" & dataStep3(8) & dataStep3(6)


		Catch ex As Exception
			MsgBox(ex.Message)
		End Try



	End Sub




	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


		Dim datas As String
		Dim dataStep1 As String
		Dim dataStep2 As String
		Dim dataStep3 As String
		Dim dataStep4 As String


		Try

			''1st step
			datas = tx_E_End.Text & tx_E_Beginning.Text
			dataStep1 = datas(0) & datas(1) & datas(3) & datas(4) & datas(6) & datas(7) & datas(8) & datas(9) & datas(11) & datas(12) & datas(14) & datas(15)

			''2nd step
			dataStep2 = datas(4) & datas(7) & datas(1) & datas(8) & datas(12) & datas(3) & datas(15) & datas(0) & datas(14) & datas(6) & datas(9) & datas(11)

			''3rd step
			Dim alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
			Dim number As String = "0123456789"
			Dim i As String = 0
			Dim J As String = 0
			dataStep3 = ""

			While i < 12
				While J < 10
					If dataStep2(i) = number(J) Then
						dataStep3 = dataStep3 & alphabet(J)
					End If
					J = J + 1

				End While
				i = i + 1
				J = 0
			End While

			''4th step
			Dim chars = "0123456789MNOPQRSTUVWXYZ"
			Dim random = New Random()
			Dim size As Integer = 2
			Dim fill1 = New String(Enumerable.Repeat(chars, size).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
			Dim fill2 = New String(Enumerable.Repeat(chars, size).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
			Dim fill3 = New String(Enumerable.Repeat(chars, size).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
			Dim fill4 = New String(Enumerable.Repeat(chars, size).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
			dataStep4 = dataStep3(0) & dataStep3(1) & dataStep3(2) & fill1 & dataStep3(3) & dataStep3(4) & dataStep3(5) & fill2 & dataStep3(6) & dataStep3(7) & dataStep3(8) & fill3 & dataStep3(9) & dataStep3(10) & dataStep3(11) & fill4

			''5th step
			tx_E_key1.Text = dataStep4(0) & dataStep4(1) & dataStep4(2) & dataStep4(3) & dataStep4(4)
			tx_E_Key2.Text = dataStep4(5) & dataStep4(6) & dataStep4(7) & dataStep4(8) & dataStep4(9)
			tx_E_Key3.Text = dataStep4(10) & dataStep4(11) & dataStep4(12) & dataStep4(13) & dataStep4(14)
			tx_E_Key4.Text = dataStep4(15) & dataStep4(16) & dataStep4(17) & dataStep4(18) & dataStep4(19)


		Catch ex As Exception
			MsgBox(ex.Message)
		End Try



	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


		tx_D_Key1.Text = tx_E_key1.Text
		tx_D_Key2.Text = tx_E_Key2.Text
		tx_D_Key3.Text = tx_E_Key3.Text
		tx_D_Key4.Text = tx_E_Key4.Text

	End Sub
End Class
