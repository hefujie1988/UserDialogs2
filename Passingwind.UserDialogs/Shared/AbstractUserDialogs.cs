﻿using System;

namespace Passingwind.UserDialogs
{
    public abstract class AbstractUserDialogs : IUserDialogs
    {
        //static void Cancel<TResult>(IDisposable disp, TaskCompletionSource<TResult> tcs)
        //{
        //    disp.Dispose();
        //    tcs.TrySetCanceled();
        //}

        public void Toast(string message)
        {
            Toast(new ToastConfig() { Message = message });
        }

        public abstract void Toast(ToastConfig options);

        public IDisposable Snackbar(string message, Action action = null)
        {
            return Snackbar(new SnackbarConfig() { Message = message, Action = action });
        }

        public abstract IDisposable Snackbar(SnackbarConfig config);

        public IDisposable Alert(string message)
        {
            return Alert(new AlertConfig(message));
        }

        public abstract IDisposable Alert(AlertConfig config);

        public abstract IDisposable ActionSheet(ActionSheetConfig config);

        public abstract IDisposable Loading(LoadingConfig config);

        public abstract IProgressDialog Progress(ProgressConfig config);

        public abstract void Prompt(PromptConfig config);

    }
}