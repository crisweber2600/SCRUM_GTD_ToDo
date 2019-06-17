using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
namespace Scrum_GTD_ToDo
{
    public static class Resolver
    {
        private static IContainer container;
        public static void Initialize(IContainer container)
        {
            Resolver.container = container;
        }
        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }
    }
}
