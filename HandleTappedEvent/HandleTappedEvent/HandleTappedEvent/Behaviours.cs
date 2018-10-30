using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace HandleTappedEvent
{
    [Preserve(AllMembers = true)]
    public class Behaviours : Behavior<SfListView>
    {
        private SfListView listView;
        protected override void OnAttachedTo(BindableObject bindable)
        {
            listView = bindable as SfListView;
            listView.ItemGenerator = new ItemGeneratorExt(listView);
            base.OnAttachedTo(bindable);
        }
    }
    public class ItemGeneratorExt : ItemGenerator
    {
        public ItemGeneratorExt(SfListView listview) : base(listview)
        {

        }

        protected override ListViewItem OnCreateListViewItem(int rowIndex, ItemType type, object data = null)
        {
            if (type == ItemType.Record)
            {
                return new ListViewItemExt();
            }
            return base.OnCreateListViewItem(rowIndex, type, data);
        }
    }

    public class ListViewItemExt : ListViewItem
    {
        public ListViewItemExt()
        {
        }
    }
}
