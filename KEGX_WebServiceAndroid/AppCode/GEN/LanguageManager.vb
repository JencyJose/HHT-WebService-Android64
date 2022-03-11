Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Threading


Namespace TrackITKTS

    Public NotInheritable Class LanguageManager
        ''' <summary> 
        ''' Default CultureInfo 
        ''' </summary> 
        Public Shared ReadOnly DefaultCulture As New CultureInfo("en")

        ''' <summary> 
        ''' Available CultureInfo that according resources can be found 
        ''' </summary> 
        Public Shared ReadOnly AvailableCultures As CultureInfo()

        Shared Sub New()
            ' 
            ' Available Cultures 
            ' 
            Dim availableResources As New List(Of String)()
            'Dim resourcespath As String = Path.Combine(System.Web.HttpRuntime.AppDomainAppPath, "App_GlobalResources")
            'Dim dirInfo As New DirectoryInfo(resourcespath)
            'For Each fi As FileInfo In dirInfo.GetFiles("*.*.resx", SearchOption.AllDirectories)
            '    'Take the cultureName from resx filename, will be smt like en-US 
            '    Dim cultureName As String = Path.GetFileNameWithoutExtension(fi.Name)
            '    'get rid of .resx 
            '    If cultureName.LastIndexOf(".") = cultureName.Length - 1 Then
            '        Continue For
            '    End If
            '    'doesnt accept format FileName..resx 
            '    cultureName = cultureName.Substring(cultureName.LastIndexOf(".") + 1)
            '    availableResources.Add(cultureName)
            'Next
            availableResources.Add("en")
            availableResources.Add("ar")

            Dim result As New List(Of CultureInfo)()
            For Each culture As CultureInfo In CultureInfo.GetCultures(CultureTypes.NeutralCultures)
                'If language file can be found 
                Dim str As String = culture.ToString()
                If availableResources.Contains(culture.ToString()) Then
                    result.Add(culture)
                End If
            Next

            AvailableCultures = result.ToArray()

            ' 
            ' Current Culture 
            ' 
            If Not (DefaultCulture.IsNeutralCulture) Then
                CurrentCulture = DefaultCulture
            ElseIf DefaultCulture.ToString.Equals("en") Then
                CurrentCulture = CultureInfo.GetCultureInfo("en-US")
            ElseIf DefaultCulture.ToString.Equals("ar") Then
                CurrentCulture = CultureInfo.GetCultureInfo("ar-EG")
            End If

            ' If default culture is not available, take another available one to use 
            If Not result.Contains(DefaultCulture) AndAlso result.Count > 0 Then
                If Not (result(0).IsNeutralCulture) Then
                    CurrentCulture = DefaultCulture
                ElseIf result(0).Equals("en") Then
                    CurrentCulture = CultureInfo.GetCultureInfo("en-US")
                ElseIf result(0).Equals("ar") Then
                    CurrentCulture = CultureInfo.GetCultureInfo("ar-EG")
                End If
            End If
        End Sub

        ''' <summary> 
        ''' Current selected culture 
        ''' </summary> 
        Public Shared Property CurrentCulture() As CultureInfo
            Get
                Return Thread.CurrentThread.CurrentCulture
            End Get
            Set(ByVal value As CultureInfo)
                'NOTE: 
                'Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-A"); //correct 
                'Thread.CurrentThread.CurrentCulture = new CultureInfo("fr"); //correct 
                'Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-A"); //correct as we have given locale 
                'Thread.CurrentThread.CurrentCulture = new CultureInfo("fr"); //wrong, will not work 

                Thread.CurrentThread.CurrentUICulture = value
                Thread.CurrentThread.CurrentCulture = value
            End Set
        End Property
    End Class
End Namespace