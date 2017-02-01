data:extend(
{

  {
    type = "technology",
    name = "bioplastic-processing",
    icon = "__bioplastic__/graphics/icons/bioplastic-processing.png",
    icon_size = 128,
    prerequisites =
    {
      "chemical-processing-2",
      "barrels",
    },
    effects =
    {
      {
        type = "unlock-recipe",
        recipe = "acetic-acid"
      },
      {
        type = "unlock-recipe",
        recipe = "acetic-acid-barrel-fill"
      },
      {
        type = "unlock-recipe",
        recipe = "acetic-acid-barrel-empty"
      },

      {
        type = "unlock-recipe",
        recipe = "carbon-monoxid"
      },
      {
        type = "unlock-recipe",
        recipe = "carbon-monoxid-canister-fill"
      },
      {
        type = "unlock-recipe",
        recipe = "carbon-monoxid-canister-empty"
      },

      {
        type = "unlock-recipe",
        recipe = "cellulose-container"
      },

      {
        type = "unlock-recipe",
        recipe = "methanol"
      },
      {
        type = "unlock-recipe",
        recipe = "methanol-barrel-fill"
      },
      {
        type = "unlock-recipe",
        recipe = "methanol-barrel-empty"
      },

      {
        type = "unlock-recipe",
        recipe = "sodium-sulfate"
      },
          
      {
        type = "unlock-recipe",
        recipe = "bio-plastic"
      },
          

    },
    unit =
    {
      count = 150,
      ingredients = 
      {
        {"science-pack-1", 1},
        {"science-pack-2", 1},
      },
      time = 10
    },
    order = "d-b-b2"
  },


})

