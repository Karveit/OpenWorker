﻿using Microsoft.EntityFrameworkCore;

namespace ow.Framework.Database.CharacterPosts
{
    public sealed class CharacterPostContext : BaseDbContext
    {
        public DbSet<CharacterPostModel> CharacterPosts { set; get; } = default!;

        public CharacterPostContext(DbContextOptions<CharacterPostContext> options) : base(options)
        {
        }
    }
}