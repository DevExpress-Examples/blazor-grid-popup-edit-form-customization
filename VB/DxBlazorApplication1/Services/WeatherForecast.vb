Imports System.ComponentModel.DataAnnotations

Namespace DxBlazorApplication1.Services

    Public Class WeatherForecast

        <Key>
        Public Property ID As Integer

        <Required>
        Public Property [Date] As DateTime

        <Range(0, 100)>
        Public Property TemperatureC As Integer

        Public ReadOnly Property TemperatureF As Integer
            Get
                Return 32 + CInt(TemperatureC / 0.5556)
            End Get
        End Property

        <Required>
        <MaxLength(50)>
        Public Property Summary As String?
    End Class
End Namespace
