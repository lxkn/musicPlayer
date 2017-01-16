using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mPlayer
{
    /// <summary>
    /// Interaction logic for Przycisk.xaml
    /// </summary>
    public partial class CustomButton : UserControl
    {
        public static readonly DependencyProperty SourceProperty;
        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        private static void SourceProperty_PropertyChanged(DependencyObject dobj, DependencyPropertyChangedEventArgs e)
        {
            //To be called whenever the DP is changed.            
            System.Diagnostics.Debug.WriteLine("SourceProperty changed is fired");
        }
        private static bool SourceProperty_Validate(object Value)
        {
            //Custom validation block which takes in the value of DP
            //Returns true / false based on success / failure of the validation
            //MessageBox.Show(string.Format("DataValidation is Fired : Value {0}", Value));
            return true;
        }

        private static object SourceProperty_CoerceValue(DependencyObject dobj, object Value)
        {
            //called whenever dependency property value is reevaluated. The return value is the
            //latest value set to the dependency property
            //MessageBox.Show(string.Format("CoerceValue is fired : Value {0}", Value));
            return Value;
        }
        static CustomButton()
        {
            SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(CustomButton),
                new FrameworkPropertyMetadata(null,
                                              FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Journal,
                                              new PropertyChangedCallback(SourceProperty_PropertyChanged),
                                              new CoerceValueCallback(SourceProperty_CoerceValue),
                                              false, UpdateSourceTrigger.PropertyChanged),
                                          new ValidateValueCallback(SourceProperty_Validate));

        }

        public CustomButton()
        {
            InitializeComponent();

        }

    }
}
