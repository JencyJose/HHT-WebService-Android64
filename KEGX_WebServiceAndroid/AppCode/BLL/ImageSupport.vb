Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging

Namespace TrackITKTS.BusinessLogicLayer

	Public Class clsImageSupport

		Public Shared Function CreateThumbNail(ByVal postedFile As Bitmap, ByVal width As Integer, ByVal height As Integer) As Bitmap
			Dim bmpOut As System.Drawing.Bitmap
			Dim Format As ImageFormat = postedFile.RawFormat
			Dim Ratio As Decimal
			Dim NewWidth As Integer
			Dim NewHeight As Integer
			'*** If the image is smaller than a thumbnail just return it        
			If postedFile.Width < width AndAlso postedFile.Height < height Then
				Return postedFile
			End If
			If (postedFile.Width > postedFile.Height) Then
				Ratio = Convert.ToDecimal(width / postedFile.Width)
				NewWidth = width
				Dim Temp As Decimal = postedFile.Height * Ratio
				NewHeight = Convert.ToInt32(Temp)
			Else
				Ratio = Convert.ToDecimal(height / postedFile.Height)
				NewHeight = height
				Dim Temp As Decimal = postedFile.Width * Ratio
				NewWidth = Convert.ToInt32(Temp)
			End If
			bmpOut = New Bitmap(NewWidth, NewHeight)
			Dim g As Graphics = Graphics.FromImage(bmpOut)
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			g.FillRectangle(Brushes.White, 0, 0, NewWidth, NewHeight)
			g.DrawImage(postedFile, 0, 0, NewWidth, NewHeight)
			postedFile.Dispose()
			Return bmpOut
		End Function

	End Class

End Namespace
