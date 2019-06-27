using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescendantsLibrary
{
    public static class ControlExtensions
    {
        public static List<TextBox> TextBoxList(this Control pControl)
        {
            return pControl.Descendants<TextBox>().ToList();
        }
        public static List<CheckBox> CheckBoxList(this Control pControl)
        {
            return pControl.Descendants<CheckBox>().ToList();
        }
        public static List<ComboBox> ComboBoxList(this Control pControl)
        {
            return pControl.Descendants<ComboBox>().ToList();
        }
        public static List<PictureBox> PictureBoxList(this Control pControl)
        {
            return pControl.Descendants<PictureBox>().ToList();
        }
        public static List<Panel> PanelList(this Control pControl)
        {
            return pControl.Descendants<Panel>().ToList();
        }
        public static List<RadioButton> RadioButtonList(this Control pControl)
        {
            return pControl.Descendants<RadioButton>().ToList();
        }
        public static List<NumericUpDown> NumericUpDownList(this Control pControl)
        {
            return pControl.Descendants<NumericUpDown>().ToList();
        }
        /// <summary>
        /// Get a collection of a specific type of control from a control or form.
        /// </summary>
        /// <typeparam name="T">Type of control</typeparam>
        /// <param name="control">Control to traverse</param>
        /// <returns>IEnumerable of T</returns>
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                T thisControl = child as T;
                if (thisControl != null)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
    }
}
