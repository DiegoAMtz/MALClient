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
using Com.Orhanobut.Dialogplus;
using Com.Shehabic.Droppy;
using MALClient.Android.DIalogs;
using MALClient.Android.Resources;
using MALClient.XShared.ViewModels.Details;

namespace MALClient.Android.Flyouts
{
    public static class AnimeDetailsPageMoreFlyoutBuilder
    {
        public static DroppyMenuPopup BuildForAnimeDetailsPage(Context context,AnimeDetailsPageViewModel viewModel,View parent,Action<int> listener)
        {
            AnimeListPageFlyoutBuilder.ParamRelativeLayout = new ViewGroup.LayoutParams(DimensionsHelper.DpToPx(150), -2);

            var droppyBuilder = new DroppyMenuPopup.Builder(context, parent);
            AnimeListPageFlyoutBuilder.InjectAnimation(droppyBuilder);

            

            droppyBuilder.AddMenuItem(new DroppyMenuCustomItem(AnimeListPageFlyoutBuilder.BuildItem(context, "Forum board", listener, 0)));
            if(viewModel.AnimeMode)
                droppyBuilder.AddMenuItem(new DroppyMenuCustomItem(AnimeListPageFlyoutBuilder.BuildItem(context, "Promotional videos", listener, 1,null,null,true,null,true)));
            if(!viewModel.AddAnimeVisibility)
                droppyBuilder.AddMenuItem(new DroppyMenuCustomItem(AnimeListPageFlyoutBuilder.BuildItem(context, "Tags", listener, 2)));
            if (viewModel.IsRewatchingButtonVisibility)
                droppyBuilder.AddMenuItem(
                    new DroppyMenuCustomItem(
                        AnimeListPageFlyoutBuilder.BuildItem(context, viewModel.RewatchingLabel, listener, 6, viewModel.IsRewatching ? (int?)ResourceExtension.AccentColour : null)));
            droppyBuilder.AddMenuItem(new DroppyMenuCustomItem(AnimeListPageFlyoutBuilder.BuildItem(context, "Set rewatch count", listener, 8)));
            droppyBuilder.AddMenuItem(new DroppyMenuCustomItem(AnimeListPageFlyoutBuilder.BuildItem(context, "Copy title", listener, 7)));
            droppyBuilder.AddMenuItem(new DroppyMenuCustomItem(AnimeListPageFlyoutBuilder.BuildItem(context, "Copy link", listener, 3)));
            droppyBuilder.AddMenuItem(new DroppyMenuCustomItem(AnimeListPageFlyoutBuilder.BuildItem(context, "Open in browser", listener, 4)));
            if (!viewModel.AddAnimeVisibility)
                droppyBuilder.AddMenuItem(new DroppyMenuCustomItem(AnimeListPageFlyoutBuilder.BuildItem(context, "Remove from my list", listener, 5)));
            //if (viewModel.AiringNotificationsButtonVisibility)
            //    droppyBuilder.AddMenuItem(
            //        new DroppyMenuCustomItem(
            //            AnimeListPageFlyoutBuilder.BuildItem(context, "Air Notifications", listener, 8,
            //                viewModel.AreAirNotificationsEnabled ? (int?) ResourceExtension.AccentColour : null,
            //                viewModel.AreAirNotificationsEnabled
            //                    ? (int?) ResourceExtension.White
            //                    : null)));

            return droppyBuilder.Build();
        }
    }
}