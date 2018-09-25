﻿using Passingwind.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.Alert(new AlertConfig("you title", "message: " + DateTime.Now.ToString()));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            // await UserDialogs.Instance.ToastAsync(new ToastConfig(DateTime.Now.ToString()));
            UserDialogs.Instance.Toast(new ToastConfig(DateTime.Now.ToString()).SetStyle(ToastStyle.Snackbar));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading(new LoadingConfig("loading..."));

            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                UserDialogs.Instance.HideLoading();

                return false;
            });
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            var config = new ConfirmConfig("标题", "这是提示文本" + DateTime.Now.ToString())
                .SetOkAction(() =>
                {
                    UserDialogs.Instance.Toast(new ToastConfig("you click ok action"));
                })
                .SetCancelAction(() =>
                {
                    UserDialogs.Instance.Toast(new ToastConfig("cancaled"));
                });

            var dis = UserDialogs.Instance.Confirm(config);

            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                dis.Dispose();

                return false;
            });
        }

        private void ActionSheet_Clicked(object sender, EventArgs e)
        {
            var config = new ActionSheetConfig()
            {
                Title = "title",

                BottomSheet = true,
            }
            .SetCancel(action: () => Toast("canceled"))
            .SetDestructive(action: () => Toast("destructived"))
            .AddOption("options1", () => Toast("options1 clicked"), "ic_android_black_24dp")
            .AddOption("options2", () => Toast("options2 clicked"), "ic_3d_rotation_black_24dp")
            .AddOption("options3")
            ;

            UserDialogs.Instance.ActionSheet(config);
        }


        void Toast(string message)
        {
            UserDialogs.Instance.Toast(new ToastConfig(message));
        }
    }
}
