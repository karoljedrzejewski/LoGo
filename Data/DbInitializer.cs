using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoGo.Entities;

namespace LoGo.Data
{
    public static class DbInitializer
    {
      public static void Initialize(StoreContext context)
        {
            if (context.Logos.Any()) return;

            var logos = new List<Logo>
            {
                new Logo
                {
                    Name = "Apple",
                    Description = "Simple logo which could fit perfectly with brand connected to technology.",
                    Price = 200000,
                    PictureUrl = "images/logos/apple.png",
                    Characteristics = "Simple, apple, grey, white, bite, monochromatic",
                    Availability = true
                },
                new Logo
                {
                    Name = "BMW",
                    Description = "Logo straight from Bavaria, could be used as icon of comfortable and fast cars.",
                    Price = 150000,
                    PictureUrl = "images/logos/bmw.png",
                    Characteristics = "White, lightblue, black, silver, circle, Bavaria, fade, target",
                    Availability = true
                },
                new Logo
                {
                    Name = "Harvard",
                    Description = "Logo connected to science with latin word 'veritas' which means truth.",
                    Price = 400000,
                    PictureUrl = "images/logos/harvard.png",
                    Characteristics = "Red, white, black, veritas, truth, science, latin",
                    Availability = true
                },
                new Logo
                {
                    Name = "Microsoft",
                    Description = "Four squares of different colors, looks like window. Would suit a precursor tech company.",
                    Price = 300000,
                    PictureUrl = "images/logos/microsoft.png",
                    Characteristics = "Red, green, lightblue, yellow, window, symmetrical",
                    Availability = true
                },
                new Logo
                {
                    Name = "Netflix",
                    Description = "Big red N, would suit some possible to subscribe services.",
                    Price = 300000,
                    PictureUrl = "images/logos/netflix.png",
                    Characteristics = "Letter N, different r shades, simple, symmetrical",
                    Availability = true
                },
                new Logo
                {
                    Name = "Oxford",
                    Description = "Two majestic lions holding shield to defend from bad events. Could be a good oldschool university Logo",
                    Price = 200000,
                    PictureUrl = "images/logos/oxford.png",
                    Characteristics = "Blue, white, lion, shield, oldschool, medieval",
                    Availability = true
                },
                new Logo
                {
                    Name = "Ferrari",
                    Description = "Black horse on yellow background, looks fast. On upper part of logo there is flag of Iran.",
                    Price = 700000,
                    PictureUrl = "images/logos/ferrari.png",
                    Characteristics = "Horse, mustang, Iran, yellow, fast, crooked legs",
                    Availability = true
                },
                new Logo
                {
                    Name = "Intel",
                    Description = "Blue text 'intel' on white background, possible connection with science and knowledge. ",
                    Price = 400000,
                    PictureUrl = "images/logos/intel.png",
                    Characteristics = "Blue, white, intel, knowledge, data, science, simplicity",
                    Availability = true
                },
                new Logo
                {
                    Name = "PG",
                    Description = "One of our worst creation, if you're masochist you could use it as your company logo.",
                    Price = 10000,
                    PictureUrl = "images/logos/pg.png",
                    Characteristics = "Ugly, weird animals on sides, holding blue shield which can protect nothing",
                    Availability = true
                },
                new Logo
                {
                    Name = "UG",
                    Description = "Our GIGACHAD creation, best of them all. Modern style connected with rich Christian history equals best possible combination.",
                    Price = 1000000,
                    PictureUrl = "images/logos/ug.png",
                    Characteristics = "GIGACHAD, awesome, pretty, stylish, soul, Christian, domination",
                    Availability = true
                },
                new Logo
                {
                    Name = "Smart",
                    Description = "Simple logo which can do as come programming language logo. Looks cool, definitely cooler than just C or C with two pluses",
                    Price = 200000,
                    PictureUrl = "images/logos/smart.png",
                    Characteristics = "Programming, C, grey, yellow, massive",
                    Availability = true
                },
                new Logo
                {
                    Name = "Tesla",
                    Description = "Some kind of broken red-from-blood two-handed viking axe. Would fit well for vehicle factory company. ",
                    Price = 500000,
                    PictureUrl = "images/logos/tesla.png",
                    Characteristics = "Two-handed axe, vikings, blood, aggressive, modern, red",
                    Availability = true
                },
            };

            foreach (var logo in logos)
            {
                context.Logos.Add(logo);
            }

            context.SaveChanges();
        }
    }
}