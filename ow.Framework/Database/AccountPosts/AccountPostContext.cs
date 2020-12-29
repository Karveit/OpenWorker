﻿using Microsoft.EntityFrameworkCore;

namespace ow.Framework.Database.AccouintPosts
{
    public sealed class AccountPostContext : BaseDbContext
    {
        public DbSet<AccountPostModel> AccountsPosts { set; get; } = default!;

        public AccountPostContext(DbContextOptions<AccountPostContext> options) : base(options)
        {
        }
    }
}