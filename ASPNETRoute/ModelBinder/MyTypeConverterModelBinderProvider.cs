using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace ASPNETRoute.ModelBinder
{
    public class MyTypeConverterModelBinderProvider : ModelBinderProvider
    {
        public MyTypeConverterModelBinderProvider() { }
        public override IModelBinder GetBinder(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext)
        {

            return null;
        }
    }
}