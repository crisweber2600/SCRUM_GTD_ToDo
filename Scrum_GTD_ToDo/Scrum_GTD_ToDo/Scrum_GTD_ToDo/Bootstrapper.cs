using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using System.Linq;
using Xamarin.Forms;
using Scrum_GTD_ToDo.Repositories;
using Scrum_GTD_ToDo.ViewModels;
using Scrum_GTD_ToDo.Views;
using System.Reflection;

namespace Scrum_GTD_ToDo
{
    public abstract class Bootstrapper
    {
        protected ContainerBuilder ContainerBuilder { get; private set; }
        public Bootstrapper()
        {
            Initialize();
            FinishInitialization();
        }
        protected virtual void Initialize()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            ContainerBuilder = new ContainerBuilder();
            foreach(var type in currentAssembly.DefinedTypes.Where(e => e.IsSubclassOf(typeof(Page))||e.IsSubclassOf(typeof(ViewModel))))
            {
                ContainerBuilder.RegisterType(type.AsType());
            }
            ContainerBuilder.RegisterType<TodoItemRepository>().SingleInstance();
        }
        private void FinishInitialization()
        {
            var container = ContainerBuilder.Build();
            Resolver.Initialize(container);
        }
    }
}
