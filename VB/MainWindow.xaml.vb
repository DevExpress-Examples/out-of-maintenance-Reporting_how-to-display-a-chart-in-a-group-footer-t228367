Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Printing

Namespace WpfApplication1
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            Dim report As New XtraReport1()
            report.CreateDocument()
            documentViewer1.Model = New XtraReportPreviewModel(report)
        End Sub
    End Class
End Namespace
