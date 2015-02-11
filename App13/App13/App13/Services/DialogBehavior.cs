using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App13.Services
{
    public class DialogBehavior : Behavior<Page>
    {
        protected override void OnAttachedTo(Page bindable)
        {
            base.OnAttachedTo(bindable);
            Messenger.Default.Register<NotificationMessage>(this, x => bindable.DisplayAlert("メッセージ", x.Notification, "OK"));
        }

        protected override void OnDetachingFrom(Page bindable)
        {
            base.OnDetachingFrom(bindable);
            Messenger.Default.Unregister<NotificationMessage>(this);
        }
    }
}
