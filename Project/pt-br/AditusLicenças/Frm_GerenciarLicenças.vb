Imports System.Data.SqlClient



Public Class Frm_GerenciarLicenças


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button5.Click


		Dim data1etapa As String
		Dim data2Etapa As String
		Dim data3Etapa As String

		Try

			''1 etapa
			data1etapa = tx_1.Text & tx_2.Text & tx_3.Text & tx_4.Text

			''2 etapa
			data2Etapa = data1etapa(0) & data1etapa(1) & data1etapa(2) & data1etapa(5) & data1etapa(6) & data1etapa(7) & data1etapa(10) & data1etapa(11) & data1etapa(12) & data1etapa(15) & data1etapa(16) & data1etapa(17)

			''3 etapa
			data3Etapa = ""
			Dim alfabeto As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
			Dim numeros As String = "0123456789"
			Dim i As String = 0
			Dim J As String = 0
			While i < 12
				While J < 10
					If data2Etapa(i) = alfabeto(J) Then
						data3Etapa = data3Etapa & numeros(J)
					End If
					J = J + 1
				End While
				i = i + 1
				J = 0
			End While

			''4 etapa 
			tx_final2.Text = data3Etapa(7) & data3Etapa(2) & "/" & data3Etapa(5) & data3Etapa(0) & "/" & data3Etapa(9) & data3Etapa(1)
			tx_inicio2.Text = data3Etapa(3) & data3Etapa(10) & "/" & data3Etapa(11) & data3Etapa(4) & "/" & data3Etapa(8) & data3Etapa(6)


		Catch ex As Exception
			MsgBox(ex.Message)
		End Try



	End Sub




	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


		Dim datas As String
		Dim data1etapa As String
		Dim data2Etapa As String
		Dim data3etapa As String
		Dim data4Etapa As String


		Try

			''1 etapa
			datas = tx_Final.Text & tx_Inicio.Text
			data1etapa = datas(0) & datas(1) & datas(3) & datas(4) & datas(6) & datas(7) & datas(8) & datas(9) & datas(11) & datas(12) & datas(14) & datas(15)

			''2 etapa
			data2Etapa = datas(4) & datas(7) & datas(1) & datas(8) & datas(12) & datas(3) & datas(15) & datas(0) & datas(14) & datas(6) & datas(9) & datas(11)

			''3 etapa
			Dim alfabeto As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
			Dim numeros As String = "0123456789"
			Dim i As String = 0
			Dim J As String = 0
			data3etapa = ""

			While i < 12
				While J < 10
					If data2Etapa(i) = numeros(J) Then
						data3etapa = data3etapa & alfabeto(J)
					End If
					J = J + 1

				End While
				i = i + 1
				J = 0
			End While

			''4 etapa
			Dim chars = "0123456789MNOPQRSTUVWXYZ"
			Dim random = New Random()
			Dim tamanho As Integer = 2
			Dim preenchimento1 = New String(Enumerable.Repeat(chars, tamanho).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
			Dim preenchimento2 = New String(Enumerable.Repeat(chars, tamanho).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
			Dim preenchimento3 = New String(Enumerable.Repeat(chars, tamanho).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
			Dim preenchimento4 = New String(Enumerable.Repeat(chars, tamanho).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
			data4Etapa = data3etapa(0) & data3etapa(1) & data3etapa(2) & preenchimento1 & data3etapa(3) & data3etapa(4) & data3etapa(5) & preenchimento2 & data3etapa(6) & data3etapa(7) & data3etapa(8) & preenchimento3 & data3etapa(9) & data3etapa(10) & data3etapa(11) & preenchimento4

			''5 etapa
			tx_1chave.Text = data4Etapa(0) & data4Etapa(1) & data4Etapa(2) & data4Etapa(3) & data4Etapa(4)
			tx_2chave.Text = data4Etapa(5) & data4Etapa(6) & data4Etapa(7) & data4Etapa(8) & data4Etapa(9)
			tx_3chave.Text = data4Etapa(10) & data4Etapa(11) & data4Etapa(12) & data4Etapa(13) & data4Etapa(14)
			tx_4chave.Text = data4Etapa(15) & data4Etapa(16) & data4Etapa(17) & data4Etapa(18) & data4Etapa(19)


		Catch ex As Exception
			MsgBox(ex.Message)
		End Try



	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


		tx_1.Text = tx_1chave.Text
		tx_2.Text = tx_2chave.Text
		tx_3.Text = tx_3chave.Text
		tx_4.Text = tx_4chave.Text

	End Sub
End Class
