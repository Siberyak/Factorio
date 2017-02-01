data:extend({
--------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------

  { --  сульфид натрия (sodium sulfate): 2 NaCl + H2SO4 -> 2 HCl + Na2SO4
    type = "recipe",
    name = "sodium-sulfate",
    category = "chemical-furnace",
    enabled = "false",
    energy_required = 2,
    ingredients =
    {
      {type="item", name="salt", amount=2},
      {type="fluid", name="sulfuric-acid", amount=1}
    },
    results=
    {
      {type="item", name="sodium-sulfate-container", amount=1},
      {type="fluid", name="hydrogen-chloride", amount=2},
    },
    icon = "__bioplastic__/graphics/icons/sodium-sulfate.png",
    subgroup = "bob-material-chemical",
    order = "b[fluid-chemistry]-b[sodium-sulfate]"
  },

--------------------------------------------------------------------------------------------

  { --  моноксид углерода: 2 C + O2 -> 2 CO
    type = "recipe",
    name = "carbon-monoxid",
    category = "chemistry",
    subgroup = "bob-fluid",
--    category = "chemical-furnace",
--    subgroup = "bob-material-chemical",
    enabled = "false",
    energy_required = 2,
    ingredients =
    {
      {type="item", name="carbon", amount=2},
      {type="fluid", name="oxygen", amount=1}
    },
    results=
    {
      {type="fluid", name="carbon-monoxid", amount=2},
    },
    icon = "__bioplastic__/graphics/icons/carbon-monoxid.png",
    order = "b[fluid-chemistry]-b[carbon-monoxid]"
  },


  {
    type = "recipe",
    name = "carbon-monoxid-canister-fill",
    icon = "__bioplastic__/graphics/icons/carbon-monoxid-canister-fill.png",
    category = "water-pump",
    energy_required = 1,
    enabled = "false",
    ingredients =
    {
      {type="fluid", name="carbon-monoxid", amount=5},
      {type="item", name="gas-canister", amount=1},
    },
    results=
    {
      {type="item", name="carbon-monoxid-canister", amount=1}
    },
    main_product= "carbon-monoxid-canister",
    order = "b[carbon-monoxid-canister-fill]",
    subgroup = "bob-gas-bottle",
  },

  {
    type = "recipe",
    name = "carbon-monoxid-canister-empty",
    icon = "__bioplastic__/graphics/icons/carbon-monoxid-canister-empty.png",
    category = "water-pump",
    energy_required = 1,
    enabled = "false",
    ingredients =
    {
      {type="item", name="carbon-monoxid-canister", amount=1}
    },
    results=
    {
      {type="fluid", name="carbon-monoxid", amount=5},
      {type="item", name="gas-canister", amount=1}
    },
    main_product= "carbon-monoxid",
    order = "c[carbon-monoxid-canister-empty]",
    subgroup = "bob-empty-gas-bottle",
  },

--------------------------------------------------------------------------------------------

  { --  метанол: CO + 2 H2 -> CH3-OH
    type = "recipe",
    name = "methanol",
    category = "chemistry",
    enabled = "false",
    energy_required = 2,
    ingredients =
    {
      {type="fluid", name="carbon-monoxid", amount=1},
      {type="fluid", name="hydrogen", amount=2}
    },
    results=
    {
      {type="fluid", name="methanol", amount=1},
    },
    icon = "__bioplastic__/graphics/icons/methanol.png",
    subgroup = "bob-fluid",
    order = "b[fluid-chemistry]-b[methanol]"
  },


  {
    type = "recipe",
    name = "methanol-barrel-fill",
    icon = "__bioplastic__/graphics/icons/methanol-barrel-fill.png",
    category = "water-pump",
    energy_required = 1,
    enabled = "false",
    ingredients =
    {
      {type="fluid", name="methanol", amount=25},
      {type="item", name="empty-barrel", amount=1},
    },
    results=
    {
      {type="item", name="methanol-barrel", amount=1}
    },
    main_product= "methanol-barrel",
    order = "b[methanol-barrel-fill]",
    subgroup = "bob-barrel",
  },

  {
    type = "recipe",
    name = "methanol-barrel-empty",
    icon = "__bioplastic__/graphics/icons/methanol-barrel-empty.png",
    category = "water-pump",
    energy_required = 1,
    enabled = "false",
    ingredients =
    {
      {type="item", name="methanol-barrel", amount=1}
    },
    results=
    {
      {type="fluid", name="methanol", amount=25},
      {type="item", name="empty-barrel", amount=1}
    },
    main_product= "methanol",
    order = "c[methanol-barrel-empty]",
    subgroup = "bob-empty-barrel",
  },

--------------------------------------------------------------------------------------------


  { -- уксусная кислота: CH3-OH + CO -> CH3-CO-OH
    type = "recipe",
    name = "acetic-acid",
    category = "chemistry",
    enabled = "false",
    energy_required = 2,
    ingredients =
    {
      {type="fluid", name="carbon-monoxid", amount=1},
      {type="fluid", name="methanol", amount=1}
    },
    results=
    {
      {type="fluid", name="acetic-acid", amount=1},
    },
    icon = "__bioplastic__/graphics/icons/acetic-acid.png",
    subgroup = "bob-fluid",
    order = "b[fluid-chemistry]-b[acetic-acid]"
  },

  {
    type = "recipe",
    name = "acetic-acid-barrel-fill",
    icon = "__bioplastic__/graphics/icons/acetic-acid-barrel-fill.png",
    category = "water-pump",
    subgroup = "bob-barrel",
    energy_required = 1,
    enabled = "false",
    ingredients =
    {
      {type="fluid", name="acetic-acid", amount=25},
      {type="item", name="empty-barrel", amount=1},
    },
    results=
    {
      {type="item", name="acetic-acid-barrel", amount=1}
    },
    main_product= "acetic-acid-barrel",
    order = "b[acetic-acid-barrel-fill]",
  },

  {
    type = "recipe",
    name = "acetic-acid-barrel-empty",
    icon = "__bioplastic__/graphics/icons/acetic-acid-barrel-empty.png",
    category = "water-pump",
    subgroup = "bob-empty-barrel",
    energy_required = 1,
    enabled = "false",
    ingredients =
    {
      {type="item", name="acetic-acid-barrel", amount=1}
    },
    results=
    {
      {type="fluid", name="acetic-acid", amount=25},
      {type="item", name="empty-barrel", amount=1}
    },
    main_product= "acetic-acid",
    order = "c[acetic-acid-barrel-empty]",
  },

-------------------------------------------------------------------------------------
  { -- cellulose
    type = "recipe",
    name = "cellulose-container",
    icon = "__bioplastic__/graphics/icons/cellulose.png",
    category = "crafting-with-fluid",
    energy_required = 5,
    enabled = "false",
    ingredients =
    {
      {type="fluid", name="water", amount=5},
      {type="item", name="sodium-sulfate-container", amount=5},
      {type="item", name="sodium-hydroxide", amount=5},
      {type="item", name="sawdust-container", amount=5}
    },
    results=
    {
      {type="item", name="cellulose-container", amount=5}
    },
    main_product= "cellulose-container",
    subgroup = "bob-material-chemical",
    order = "c[cellulose-container]",
  },



-------------------------------------------------------------------------------------
  { -- sawdust
    type = "recipe",
    name = "sawdust-container",
    icon = "__bioplastic__/graphics/icons/sawdust.png",
    energy_required = 2,
    enabled = "true",
    ingredients =
    {
      {type="item", name="raw-wood", amount=1}
    },
    results=
    {
      {type="item", name="sawdust-container", amount=2}
    },
    main_product= "sawdust-container",
    order = "c[sawdust-container]",
  },

  {
    type = "recipe",
    name = "bio-plastic",
    category = "chemistry",
    icon = "__base__/graphics/icons/plastic-bar.png",
    energy_required = 5,
    enabled = false,
    ingredients =
    {
      {type="fluid", name="acetic-acid", amount=2},
      {type="item", name="cellulose-container", amount=10}
    },
    results=
    {
      {type="item", name="plastic-bar", amount=2}
    },
  },


})
