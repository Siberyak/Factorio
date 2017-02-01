data:extend({

  {-- бочка уксусной кислоты
    type = "item",
    name = "acetic-acid-barrel",
    icon = "__bioplastic__/graphics/icons/acetic-acid-barrel.png",
    flags = {"goes-to-main-inventory"},
    subgroup = "bob-resource-chemical",
    order = "f[acetic-acid-barrel]",
    stack_size = 20
  },

  {
    type = "fluid",
    name = "acetic-acid",
    default_temperature = 25,
    heat_capacity = "1KJ",
    base_color = {r=1.0, g=1.0, b=1.0},
    flow_color = {r=0.0, g=0.0, b=0.0},
    max_temperature = 100,
    icon = "__bioplastic__/graphics/icons/acetic-acid.png",
    pressure_to_speed_ratio = 0.4,
    flow_to_energy_ratio = 0.59,
    order = "a[fluid]-g[acetic-acid]"
  },


  {-- баллон угарного газа (моноксид углерода)
    type = "item",
    name = "carbon-monoxid-canister",
    icon = "__bioplastic__/graphics/icons/carbon-monoxid-canister.png",
    flags = {"goes-to-main-inventory"},
    subgroup = "bob-resource-chemical",
    order = "f[carbon-monoxid-canister]",
    stack_size = 100
  },

  {
    type = "fluid",
    name = "carbon-monoxid",
    default_temperature = 25,
    heat_capacity = "1KJ",
    base_color = {r=1.0, g=1.0, b=1.0},
    flow_color = {r=0.0, g=0.0, b=0.0},
    max_temperature = 100,
    icon = "__bioplastic__/graphics/icons/carbon-monoxid.png",
    pressure_to_speed_ratio = 0.4,
    flow_to_energy_ratio = 0.59,
    order = "a[fluid]-g[carbon-monoxid]"
  },

  {-- ящик целлюлозы
    type = "item",
    name = "cellulose-container",
    icon = "__bioplastic__/graphics/icons/cellulose-container.png",
    flags = {"goes-to-main-inventory"},
    subgroup = "bob-resource-chemical",
    order = "f[cellulose-container]",
    stack_size = 500
  },

  {-- бочка метанола
    type = "item",
    name = "methanol-barrel",
    icon = "__bioplastic__/graphics/icons/methanol-barrel.png",
    flags = {"goes-to-main-inventory"},
    subgroup = "bob-resource-chemical",
    order = "f[methanol-barrel]",
    stack_size = 20
  },


  {
    type = "fluid",
    name = "methanol",
    default_temperature = 25,
    heat_capacity = "1KJ",
    base_color = {r=1.0, g=1.0, b=1.0},
    flow_color = {r=0.0, g=0.0, b=0.0},
    max_temperature = 100,
    icon = "__bioplastic__/graphics/icons/methanol.png",
    pressure_to_speed_ratio = 0.4,
    flow_to_energy_ratio = 0.59,
    order = "a[fluid]-g[methanol]"
  },

  {-- ящик сульфата натрия
    type = "item",
    name = "sodium-sulfate-container",
    icon = "__bioplastic__/graphics/icons/sodium-sulfate-container.png",
    flags = {"goes-to-main-inventory"},
    subgroup = "bob-resource-chemical",
    order = "f[sodium-sulfate-container]",
    stack_size = 500
  },

  {-- ящик опилок
    type = "item",
    name = "sawdust-container",
    icon = "__bioplastic__/graphics/icons/sawdust-container.png",
    flags = {"goes-to-main-inventory"},
    subgroup = "intermediate-product",
    order = "f[sawdust-container]",
    stack_size = 100
  },


})
