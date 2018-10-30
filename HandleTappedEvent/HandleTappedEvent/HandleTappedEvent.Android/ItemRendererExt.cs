using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HandleTappedEvent;
using Syncfusion.ListView.XForms.Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(ListViewItemExt), typeof(ItemRendererExt))]
namespace HandleTappedEvent
{
    public class ItemRendererExt : ListViewItemRenderer
    {
        public override void OnClick(Android.Views.View view)
        {
            return;
        }
    }
}