﻿using Microsoft.AspNetCore.Builder;

namespace MaSurvey.Infrastructure.SqlTableDependency.Middleware
{
    static public class DatabaseSubscriptionMiddleware
    {
        public static void UseDatabaseSubscription<T>(this IApplicationBuilder builder, string tableName) where T : class , IDatabaseSubscription
        {
            var sub = (T)builder.ApplicationServices.GetService(typeof(T));
            sub.Configure(tableName);
        }
    }
}
