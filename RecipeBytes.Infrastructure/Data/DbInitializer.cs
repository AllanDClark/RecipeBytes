﻿using Microsoft.EntityFrameworkCore;
using RecipeBytes.Domain.Entities;

namespace RecipeBytes.Infrastructure.Data
{
    public class DbInitializer(ModelBuilder modelBuilder)
    {
        private readonly ModelBuilder _modelBuilder = modelBuilder;

        public void Seed()
        {
            //_modelBuilder.Entity<Tag>().HasData(
            //    new Tag { Id = new Guid("f3ddbb7b-d75f-4cbb-9d9a-367cda92a2db"), Name = "Vegetarian", Description = "Food's food", IsSoftDeleted = false, CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue },
            //    new Tag { Id = new Guid("3b3a1493-46fd-4128-ac26-a49f1ee4f40b"), Name = "Pork", Description = "Oink oink", IsSoftDeleted = false, CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue },
            //    new Tag { Id = new Guid("51559ffa-8d5f-4494-81c8-bf16dd4fc1d5"), Name = "Chicken", Description = "Tastes like chicken", IsSoftDeleted = false, CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue }
            //    );

            _modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = new Guid("cd05ab52-40b3-4e8c-8691-ab925c60b49d"), Name = "Pork", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("60384851-3224-4b4e-ac4c-e4794e8aebe6"), Name = "Chicken", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("d8eaf201-0c64-4245-bd05-d8f9cb002976"), Name = "Carrot", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("82a1f582-833d-4949-b39a-6bf87ecced2e"), Name = "Bacon", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("cab3989e-a120-423c-b814-3eb8a00cfcf5"), Name = "Egg", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("b3dc45dc-a522-498e-818e-431524944e26"), Name = "Cabbage", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("bedf332a-c895-41ca-9b1c-09b28d8fbdd0"), Name = "Noodle", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("14d6d5a5-482e-45ab-860d-14e38407b597"), Name = "Flour", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("bedf332a-c895-41ca-9b1c-09b28d8fbdd1"), Name = "Sugar", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("bedf332a-c895-41ca-9b1c-09b28d8fbdd2"), Name = "Salt", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("bedf332a-c895-41ca-9b1c-09b28d8fbdd4"), Name = "Milk", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("bedf332a-c895-41ca-9b1c-09b28d8fbdd5"), Name = "Butter", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("bedf332a-c895-41ca-9b1c-09b28d8fbdd6"), Name = "Vanilla extract", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("bedf332a-c895-41ca-9b1c-09b28d8fbdd7"), Name = "Baking powder", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("bedf332a-c895-41ca-9b1c-09b28d8fbdd8"), Name = "Chocolate chip", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue },
                new Ingredient { Id = new Guid("bedf332a-c895-41ca-9b1c-09b28d8fbdd9"), Name = "Olive oil", Description = "", IsSoftDeleted = false, ImageUrl = "this is a url", UpdatedDate = DateTimeOffset.MinValue, CreatedDate = DateTimeOffset.MinValue }
            );

            //_modelBuilder.Entity<InstructionStep>().HasData(
            //    new InstructionStep { Id = new Guid("7e10bff2-b047-4055-a2b9-58bdc570c0e6"), Name = "", IsSoftDeleted = false, Description = "Boil water", CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue },
            //    new InstructionStep { Id = new Guid("4fe36ea2-e5e3-40a0-a7a3-55c40b08bb30"), Name = "", IsSoftDeleted = false, Description = "Put Noodles in", CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue });

            //_modelBuilder.Entity<Recipe>().HasData(new Recipe { Id = new Guid("082e3d35-95b2-409a-9ba9-c8c9b15a877b"), Name = "Pork noodles", IsSoftDeleted = false, ImageUrl = "this is a url", Description = "Noodles and pork", CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue });
            _modelBuilder.Entity<Recipe>().HasData(new Recipe { Id = new Guid("082e3d35-95b2-409a-9ba9-c8c9b15a877b"), Name = "Ramen noodles", IsSoftDeleted = false, ImageUrl = "https://res.cloudinary.com/daspbl6sb/image/upload/v1712964559/whk9yu5xsbr7cvszwtte.jpg", Description = "Noodles and pork", CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue },
                new Recipe { Id = new Guid("96a6f4e5-e108-4b8f-8c47-1a2c98d6019e"), Name = "Bacon and Eggs", IsSoftDeleted = false, ImageUrl = "https://res.cloudinary.com/daspbl6sb/image/upload/v1712964467/james-kern-aLDW0oQ0NtU-unsplash_ypclxp.jpg", Description = "What I said was, 'give me all the bacon and eggs you have.'", CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue },
                new Recipe { Id = new Guid("739defb6-3d8a-432e-a4e7-0171e22a3a0f"), Name = "Homemade Margherita Pizza", IsSoftDeleted = false, ImageUrl = "https://res.cloudinary.com/daspbl6sb/image/upload/v1712964879/bwglvzxvy9uzdwwglhzb.jpg", Description = "Marg-her-ehhh-tay", CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue },
                new Recipe { Id = new Guid("b8a3efb4-50bd-41b5-832e-3d59d783b4a9"), Name = "Carnitas Tacos", IsSoftDeleted = false, ImageUrl = "https://res.cloudinary.com/daspbl6sb/image/upload/v1712965310/o2qgx0yifaty6ikcpmf1.jpg", Description = "Why did the taco go to the party? Because it wanted to taco 'bout it later!", CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue },
                new Recipe { Id = new Guid("a2c3c1e1-f0ed-4d4d-a698-9f7ee2177d8b"), Name = "Chocolate Cake", IsSoftDeleted = false, ImageUrl = "https://res.cloudinary.com/daspbl6sb/image/upload/v1712965428/hjc02v2ngl00lc0zgxtx.jpg", Description = "It is not a lie.", CreatedDate = DateTimeOffset.MinValue, UpdatedDate = DateTimeOffset.MinValue }
                );  
            
            
            

        }
    }
}
