Imports System.Globalization
Imports System.Web.UI
Namespace TrackITKTS
    Public Class PageBase
        Inherits Page
        Private Const SESSION_KEY_LANGUAGE As String = "CURRENT_LANGUAGE"

        Protected Overloads Overrides Sub InitializeCulture()
            MyBase.InitializeCulture()

            'If you would like to have DefaultLanguage changes to effect all users, 
            ' or when the session expires, the DefaultLanguage will be chosen, do this: 
            ' (better put in somewhere more GLOBAL so it will be called once) 
            LanguageManager.CurrentCulture = CultureInfo.GetCultureInfo("ar-EG")

            'Change language setting to user-chosen one 
            If Session(SESSION_KEY_LANGUAGE) IsNot Nothing Then
                ApplyNewLanguage(DirectCast(Session(SESSION_KEY_LANGUAGE), CultureInfo))
            End If
        End Sub

        Private Sub ApplyNewLanguage(ByVal culture As CultureInfo)
            If Not (culture.IsNeutralCulture) Then
                LanguageManager.CurrentCulture = culture
            ElseIf culture.ToString.Equals("en") Then
                LanguageManager.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
            ElseIf culture.ToString.Equals("ar") Then
                LanguageManager.CurrentCulture = CultureInfo.GetCultureInfo("ar-EG")
            End If

            'LanguageManager.CurrentCulture = culture
            'Keep current language in session 
            Session.Add(SESSION_KEY_LANGUAGE, LanguageManager.CurrentCulture)
        End Sub

        Protected Sub ApplyNewLanguageAndRefreshPage(ByVal culture As CultureInfo)
            ApplyNewLanguage(culture)
            'Refresh the current page to make all control-texts take effect 
            'Response.Redirect(Request.Url.AbsoluteUri)
        End Sub
    End Class
End Namespace