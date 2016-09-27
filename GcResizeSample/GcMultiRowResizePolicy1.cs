using System;
using System.Windows.Forms;
using System.Collections.Generic;

using GrapeCity.Win.Components;
using GrapeCity.Win.MultiRow;

namespace MultiRowSample
{
    public class GcMultiRowResizePolicy : NoResizeFontResizePolicy
    {
        public override Type TargetType
        {
            get { return typeof(GcMultiRow); }
        }
        public override IEnumerable<Control> GetChildren(Control control)
        {
            return new Control[] { };
        }


        public override void ResizeLayout(Control control, ResizeLayoutInfo infos)
        {
            GcMultiRow gcMultiRow = control as GcMultiRow;
            if (gcMultiRow != null)
            {
                try
                {
                    gcMultiRow.ZoomFactor = (float)Math.Min(infos.TargetFactorX, infos.TargetFactorY);
                }
                catch (Exception ex)
                {
                }

            }
            base.ResizeLayout(control, infos);
        }
    }
}

