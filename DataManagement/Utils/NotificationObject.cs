using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.Utils
{
   /// <summary>
   /// Implementation for INotifyPropertyChanged.
   /// </summary>
   public class NotificationObject : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;

      /// <summary>
      /// Sets a property and notifies listeners that this property value has changed.
      /// </summary>
      protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string propName = null)
      {
         if (EqualityComparer<T>.Default.Equals(field, value))
         {
            return;
         }
         field = value;
         var handler = PropertyChanged;
         if (handler != null)
         {
            handler(this, new PropertyChangedEventArgs(propName));
         }
      }

      /// <summary>
      /// Notifies listeners that a property value has changed.
      /// </summary>
      protected void RaisePropertyChanged(string propName = null)
      {
         PropertyChangedEventHandler eventHandler = this.PropertyChanged;
         if (eventHandler != null)
         {
            eventHandler(this, new PropertyChangedEventArgs(propName));
         }
      }
   }
}
