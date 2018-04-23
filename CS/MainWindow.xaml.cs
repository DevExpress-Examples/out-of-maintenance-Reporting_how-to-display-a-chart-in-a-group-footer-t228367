using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Printing;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            XtraReport1 report = new XtraReport1();
            report.CreateDocument();
            documentViewer1.Model = new XtraReportPreviewModel(report);
        }
    }
}
