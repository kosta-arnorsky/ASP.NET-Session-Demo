using System.Collections.Generic;
using System.Web;

namespace SessionDemo.Code
{
    public static class SnippetHelper
    {
        private const string ItemKey = "_SessionDemoSnippetHelperItem";

        public static void RegistreAction(this HttpContext context, string action)
        {
            GetActionsInternal(context).Add(action);
        }

        public static IReadOnlyCollection<string> GetActions(this HttpContext context)
        {
            return GetActionsInternal(context);
        }

        private static List<string> GetActionsInternal(HttpContext context)
        {
            var actions = context.Items[ItemKey] as List<string>;
            if (actions == null)
            {
                actions = new List<string>();
                context.Items[ItemKey] = actions;
            }

            return actions;
        }
    }
}