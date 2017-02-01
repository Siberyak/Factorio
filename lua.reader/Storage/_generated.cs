//*************************************************************************************
//
//     G E N E R A T E D   C L A S S E S
//
//*************************************************************************************

using Newtonsoft.Json;

namespace lua.reader
{

    [JsonObject("ammo-category", MemberSerialization = MemberSerialization.OptIn)]
    public partial class AmmoCategory : TypedNamedBase
    {

    }

    [JsonObject("autoplace-control", MemberSerialization = MemberSerialization.OptIn)]
    public partial class AutoplaceControl : TypedNamedBase
    {

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("richness")]
        public bool _Richness { get; set; }

    }

    [JsonObject("damage-type", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DamageType : TypedNamedBase
    {

    }

    [JsonObject("arrow", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Arrow : Entity
    {

        [JsonProperty("arrow_picture")]
        public object _ArrowPicture { get; set; }

        [JsonProperty("blinking")]
        public bool _Blinking { get; set; }

        [JsonProperty("circle_picture")]
        public object _CirclePicture { get; set; }

    }

    [JsonObject("corpse", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Corpse : Entity
    {

        [JsonProperty("final_render_layer")]
        public string _FinalRenderLayer { get; set; }

        [JsonProperty("splash")]
        public object[] _Splash { get; set; }

        [JsonProperty("splash_speed")]
        public float _SplashSpeed { get; set; }

        [JsonProperty("time_before_removed")]
        public float _TimeBeforeRemoved { get; set; }

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("dying_speed")]
        public float _DyingSpeed { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("selectable_in_game")]
        public bool _SelectableInGame { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("collision_mask")]
        public object[] _CollisionMask { get; set; }

        [JsonProperty("ground_patch")]
        public object _GroundPatch { get; set; }

        [JsonProperty("ground_patch_higher")]
        public object _GroundPatchHigher { get; set; }

    }

    [JsonObject("decorative", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Decorative : Entity
    {

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("pictures")]
        public object[] _Pictures { get; set; }

        [JsonProperty("render_layer")]
        public string _RenderLayer { get; set; }

        [JsonProperty("selectable_in_game")]
        public bool _SelectableInGame { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    [JsonObject("explosion", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Explosion : Entity
    {

        [JsonProperty("animations")]
        public object[] _Animations { get; set; }

        [JsonProperty("created_effect")]
        public object _CreatedEffect { get; set; }

        [JsonProperty("light")]
        public object _Light { get; set; }

        [JsonProperty("sound")]
        public object _Sound { get; set; }

        [JsonProperty("animation_speed")]
        public float _AnimationSpeed { get; set; }

        [JsonProperty("smoke")]
        public string _Smoke { get; set; }

        [JsonProperty("smoke_count")]
        public float _SmokeCount { get; set; }

        [JsonProperty("smoke_slow_down_factor")]
        public float _SmokeSlowDownFactor { get; set; }

        [JsonProperty("rotate")]
        public bool _Rotate { get; set; }

        [JsonProperty("beam")]
        public bool _Beam { get; set; }

    }

    [JsonObject("flame-thrower-explosion", MemberSerialization = MemberSerialization.OptIn)]
    public partial class FlameThrowerExplosion : Explosion
    {

    }

    [JsonObject("Prototype/EntityWithHealth", MemberSerialization = MemberSerialization.OptIn)]
    public partial class EntityWithHealth : Entity
    {

    }

    [JsonObject("accumulator", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Accumulator : EntityWithHealth
    {

        [JsonProperty("charge_animation")]
        public object _ChargeAnimation { get; set; }

        [JsonProperty("charge_cooldown")]
        public float _ChargeCooldown { get; set; }

        [JsonProperty("charge_light")]
        public object _ChargeLight { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object _CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("default_output_signal")]
        public string _DefaultOutputSignal { get; set; }

        [JsonProperty("discharge_animation")]
        public object _DischargeAnimation { get; set; }

        [JsonProperty("discharge_cooldown")]
        public float _DischargeCooldown { get; set; }

        [JsonProperty("discharge_light")]
        public object _DischargeLight { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("picture")]
        public object _Picture { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    
    public partial class AssemblingMachine
    {

        [JsonProperty("allowed_effects")]
        public object[] _AllowedEffects { get; set; }

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("crafting_categories")]
        public object[] _CraftingCategories { get; set; }

        [JsonProperty("crafting_speed")]
        public float _CraftingSpeed { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("fluid_boxes")]
        public object _FluidBoxes { get; set; }

        [JsonProperty("ingredient_count")]
        public float _IngredientCount { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("module_specification")]
        public object _ModuleSpecification { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("close_sound")]
        public object _CloseSound { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("open_sound")]
        public object _OpenSound { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("working_visualisations")]
        public object[] _WorkingVisualisations { get; set; }

        [JsonProperty("mined_sound")]
        public object _MinedSound { get; set; }

        [JsonProperty("repair_sound")]
        public object _RepairSound { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("has_backer_name")]
        public bool _HasBackerName { get; set; }

        [JsonProperty("pipe_covers")]
        public object _PipeCovers { get; set; }

        [JsonProperty("scale_entity_info_icon")]
        public bool _ScaleEntityInfoIcon { get; set; }

    }

    [JsonObject("beacon", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Beacon : EntityWithHealth
    {

        [JsonProperty("allowed_effects")]
        public object[] _AllowedEffects { get; set; }

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("animation_shadow")]
        public object _AnimationShadow { get; set; }

        [JsonProperty("base_picture")]
        public object _BasePicture { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("distribution_effectivity")]
        public float _DistributionEffectivity { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("module_specification")]
        public object _ModuleSpecification { get; set; }

        [JsonProperty("radius_visualisation_picture")]
        public object _RadiusVisualisationPicture { get; set; }

        [JsonProperty("supply_area_distance")]
        public float _SupplyAreaDistance { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("car", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Car : EntityWithHealth
    {

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("braking_power")]
        public string _BrakingPower { get; set; }

        [JsonProperty("burner")]
        public object _Burner { get; set; }

        [JsonProperty("close_sound")]
        public object _CloseSound { get; set; }

        [JsonProperty("consumption")]
        public string _Consumption { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("effectivity")]
        public float _Effectivity { get; set; }

        [JsonProperty("energy_per_hit_point")]
        public float _EnergyPerHitPoint { get; set; }

        [JsonProperty("equipment_grid")]
        public string _EquipmentGrid { get; set; }

        [JsonProperty("friction")]
        public float _Friction { get; set; }

        [JsonProperty("guns")]
        public object[] _Guns { get; set; }

        [JsonProperty("inventory_size")]
        public float _InventorySize { get; set; }

        [JsonProperty("light")]
        public object[] _Light { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("open_sound")]
        public object _OpenSound { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("rotation_speed")]
        public float _RotationSpeed { get; set; }

        [JsonProperty("sound_minimum_speed")]
        public float _SoundMinimumSpeed { get; set; }

        [JsonProperty("sound_no_fuel")]
        public object[] _SoundNoFuel { get; set; }

        [JsonProperty("stop_trigger")]
        public object[] _StopTrigger { get; set; }

        [JsonProperty("stop_trigger_speed")]
        public float _StopTriggerSpeed { get; set; }

        [JsonProperty("tank_driving")]
        public bool _TankDriving { get; set; }

        [JsonProperty("terrain_friction_modifier")]
        public float _TerrainFrictionModifier { get; set; }

        [JsonProperty("turret_animation")]
        public object _TurretAnimation { get; set; }

        [JsonProperty("turret_return_timeout")]
        public float _TurretReturnTimeout { get; set; }

        [JsonProperty("turret_rotation_speed")]
        public float _TurretRotationSpeed { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("crash_trigger")]
        public object _CrashTrigger { get; set; }

    }

    public partial class Player
    {

        [JsonProperty("animations")]
        public object _Animations { get; set; }

        [JsonProperty("build_distance")]
        public float _BuildDistance { get; set; }

        [JsonProperty("collision_mask")]
        public object[] _CollisionMask { get; set; }

        [JsonProperty("crafting_categories")]
        public object[] _CraftingCategories { get; set; }

        [JsonProperty("damage_hit_tint")]
        public object _DamageHitTint { get; set; }

        [JsonProperty("destructible")]
        public bool _Destructible { get; set; }

        [JsonProperty("distance_per_frame")]
        public float _DistancePerFrame { get; set; }

        [JsonProperty("drop_item_distance")]
        public float _DropItemDistance { get; set; }

        [JsonProperty("eat")]
        public object[] _Eat { get; set; }

        [JsonProperty("healing_per_tick")]
        public float _HealingPerTick { get; set; }

        [JsonProperty("heartbeat")]
        public object[] _Heartbeat { get; set; }

        [JsonProperty("inventory_size")]
        public float _InventorySize { get; set; }

        [JsonProperty("item_pickup_distance")]
        public float _ItemPickupDistance { get; set; }

        [JsonProperty("loot_pickup_distance")]
        public float _LootPickupDistance { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("maximum_corner_sliding_distance")]
        public float _MaximumCornerSlidingDistance { get; set; }

        [JsonProperty("mining_categories")]
        public object[] _MiningCategories { get; set; }

        [JsonProperty("mining_speed")]
        public float _MiningSpeed { get; set; }

        [JsonProperty("mining_with_hands_particles_animation_positions")]
        public object[] _MiningWithHandsParticlesAnimationPositions { get; set; }

        [JsonProperty("mining_with_tool_particles_animation_positions")]
        public object[] _MiningWithToolParticlesAnimationPositions { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("reach_distance")]
        public float _ReachDistance { get; set; }

        [JsonProperty("reach_resource_distance")]
        public float _ReachResourceDistance { get; set; }

        [JsonProperty("running_sound_animation_positions")]
        public object[] _RunningSoundAnimationPositions { get; set; }

        [JsonProperty("running_speed")]
        public float _RunningSpeed { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("ticks_to_keep_aiming_direction")]
        public float _TicksToKeepAimingDirection { get; set; }

        [JsonProperty("ticks_to_keep_gun")]
        public float _TicksToKeepGun { get; set; }

        [JsonProperty("alert_when_damaged")]
        public bool _AlertWhenDamaged { get; set; }

        [JsonProperty("light")]
        public object[] _Light { get; set; }

    }

    [JsonObject("container", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Container : EntityWithHealth
    {

        [JsonProperty("enable_inventory_bar")]
        public bool _EnableInventoryBar { get; set; }

        [JsonProperty("inventory_size")]
        public float _InventorySize { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("picture")]
        public object _Picture { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object _CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("close_sound")]
        public object _CloseSound { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("open_sound")]
        public object _OpenSound { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

    }

    [JsonObject("smart-container", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SmartContainer : Container
    {

    }

    [JsonObject("logistic-container", MemberSerialization = MemberSerialization.OptIn)]
    public partial class LogisticContainer : SmartContainer
    {

        [JsonProperty("logistic_mode")]
        public string _LogisticMode { get; set; }

    }

    [JsonObject("electric-pole", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ElectricPole : EntityWithHealth
    {

        [JsonProperty("connection_points")]
        public object[] _ConnectionPoints { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("maximum_wire_distance")]
        public float _MaximumWireDistance { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("radius_visualisation_picture")]
        public object _RadiusVisualisationPicture { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("supply_area_distance")]
        public float _SupplyAreaDistance { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("copper_wire_picture")]
        public object _CopperWirePicture { get; set; }

        [JsonProperty("green_wire_picture")]
        public object _GreenWirePicture { get; set; }

        [JsonProperty("red_wire_picture")]
        public object _RedWirePicture { get; set; }

        [JsonProperty("wire_shadow_picture")]
        public object _WireShadowPicture { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("fish", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Fish : EntityWithHealth
    {

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("pictures")]
        public object[] _Pictures { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    public partial class Furnace
    {

        [JsonProperty("allowed_effects")]
        public object[] _AllowedEffects { get; set; }

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("crafting_categories")]
        public object[] _CraftingCategories { get; set; }

        [JsonProperty("crafting_speed")]
        public float _CraftingSpeed { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("light")]
        public object _Light { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("module_specification")]
        public object _ModuleSpecification { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("result_inventory_size")]
        public float _ResultInventorySize { get; set; }

        [JsonProperty("source_inventory_size")]
        public float _SourceInventorySize { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("working_visualisations")]
        public object[] _WorkingVisualisations { get; set; }

        [JsonProperty("close_sound")]
        public object _CloseSound { get; set; }

        [JsonProperty("mined_sound")]
        public object _MinedSound { get; set; }

        [JsonProperty("open_sound")]
        public object _OpenSound { get; set; }

        [JsonProperty("repair_sound")]
        public object _RepairSound { get; set; }

        [JsonProperty("fluid_boxes")]
        public object[] _FluidBoxes { get; set; }

    }

    [JsonObject("inserter", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Inserter : EntityWithHealth
    {

        [JsonProperty("circuit_connector_sprites")]
        public object _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object _CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("energy_per_movement")]
        public float _EnergyPerMovement { get; set; }

        [JsonProperty("energy_per_rotation")]
        public float _EnergyPerRotation { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("extension_speed")]
        public float _ExtensionSpeed { get; set; }

        [JsonProperty("hand_base_picture")]
        public object _HandBasePicture { get; set; }

        [JsonProperty("hand_base_shadow")]
        public object _HandBaseShadow { get; set; }

        [JsonProperty("hand_closed_picture")]
        public object _HandClosedPicture { get; set; }

        [JsonProperty("hand_closed_shadow")]
        public object _HandClosedShadow { get; set; }

        [JsonProperty("hand_open_picture")]
        public object _HandOpenPicture { get; set; }

        [JsonProperty("hand_open_shadow")]
        public object _HandOpenShadow { get; set; }

        [JsonProperty("hand_size")]
        public float _HandSize { get; set; }

        [JsonProperty("insert_position")]
        public object[] _InsertPosition { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("pickup_position")]
        public object[] _PickupPosition { get; set; }

        [JsonProperty("platform_picture")]
        public object _PlatformPicture { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("rotation_speed")]
        public float _RotationSpeed { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("filter_count")]
        public float _FilterCount { get; set; }

        [JsonProperty("stack")]
        public bool _Stack { get; set; }

    }

    [JsonObject("lab", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Lab : EntityWithHealth
    {

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("inputs")]
        public object[] _Inputs { get; set; }

        [JsonProperty("light")]
        public object _Light { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("module_specification")]
        public object _ModuleSpecification { get; set; }

        [JsonProperty("off_animation")]
        public object _OffAnimation { get; set; }

        [JsonProperty("on_animation")]
        public object _OnAnimation { get; set; }

        [JsonProperty("researching_speed")]
        public float _ResearchingSpeed { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("lamp", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Lamp : EntityWithHealth
    {

        [JsonProperty("circuit_connector_sprites")]
        public object _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object _CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage_per_tick")]
        public string _EnergyUsagePerTick { get; set; }

        [JsonProperty("glow_color_intensity")]
        public float _GlowColorIntensity { get; set; }

        [JsonProperty("glow_size")]
        public float _GlowSize { get; set; }

        [JsonProperty("light")]
        public object _Light { get; set; }

        [JsonProperty("light_when_colored")]
        public object _LightWhenColored { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("picture_off")]
        public object _PictureOff { get; set; }

        [JsonProperty("picture_on")]
        public object _PictureOn { get; set; }

        [JsonProperty("signal_to_color_mapping")]
        public object[] _SignalToColorMapping { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("market", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Market : EntityWithHealth
    {

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("picture")]
        public object _Picture { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    [JsonObject("mining-drill", MemberSerialization = MemberSerialization.OptIn)]
    public partial class MiningDrill : EntityWithHealth
    {

        [JsonProperty("animations")]
        public object _Animations { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("mining_power")]
        public float _MiningPower { get; set; }

        [JsonProperty("mining_speed")]
        public float _MiningSpeed { get; set; }

        [JsonProperty("module_specification")]
        public object _ModuleSpecification { get; set; }

        [JsonProperty("radius_visualisation_picture")]
        public object _RadiusVisualisationPicture { get; set; }

        [JsonProperty("resource_categories")]
        public object[] _ResourceCategories { get; set; }

        [JsonProperty("resource_searching_radius")]
        public float _ResourceSearchingRadius { get; set; }

        [JsonProperty("storage_slots")]
        public float _StorageSlots { get; set; }

        [JsonProperty("vector_to_place_result")]
        public object[] _VectorToPlaceResult { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("base_picture")]
        public object _BasePicture { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("fluid_box")]
        public object _FluidBox { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("Prototype/PipeConnectable", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PipeConnectable : EntityWithHealth
    {

    }

    [JsonObject("boiler", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Boiler : PipeConnectable
    {

        [JsonProperty("burner")]
        public object _Burner { get; set; }

        [JsonProperty("burning_cooldown")]
        public float _BurningCooldown { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("energy_consumption")]
        public string _EnergyConsumption { get; set; }

        [JsonProperty("fire")]
        public object _Fire { get; set; }

        [JsonProperty("fluid_box")]
        public object _FluidBox { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("structure")]
        public object _Structure { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("generator", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Generator : PipeConnectable
    {

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("effectivity")]
        public float _Effectivity { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("fluid_box")]
        public object _FluidBox { get; set; }

        [JsonProperty("fluid_usage_per_tick")]
        public float _FluidUsagePerTick { get; set; }

        [JsonProperty("horizontal_animation")]
        public object _HorizontalAnimation { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("min_perceived_performance")]
        public float _MinPerceivedPerformance { get; set; }

        [JsonProperty("performance_to_sound_speedup")]
        public float _PerformanceToSoundSpeedup { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("smoke")]
        public object[] _Smoke { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("vertical_animation")]
        public object _VerticalAnimation { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("pump", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Pump : PipeConnectable
    {

        [JsonProperty("animations")]
        public object _Animations { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object[] _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object[] _CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("fluid_box")]
        public object _FluidBox { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("pumping_speed")]
        public float _PumpingSpeed { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("pipe", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Pipe : PipeConnectable
    {

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("fluid_box")]
        public object _FluidBox { get; set; }

        [JsonProperty("horizontal_window_bounding_box")]
        public object[] _HorizontalWindowBoundingBox { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("vertical_window_bounding_box")]
        public object[] _VerticalWindowBoundingBox { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("pipe-to-ground", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PipeToGround : PipeConnectable
    {

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("fluid_box")]
        public object _FluidBox { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("underground_sprite")]
        public object _UndergroundSprite { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("player-port", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlayerPort : EntityWithHealth
    {

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

    }

    [JsonObject("radar", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Radar : EntityWithHealth
    {

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("energy_per_nearby_scan")]
        public string _EnergyPerNearbyScan { get; set; }

        [JsonProperty("energy_per_sector")]
        public string _EnergyPerSector { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("max_distance_of_nearby_sector_revealed")]
        public float _MaxDistanceOfNearbySectorRevealed { get; set; }

        [JsonProperty("max_distance_of_sector_revealed")]
        public float _MaxDistanceOfSectorRevealed { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("rail", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Rail : EntityWithHealth
    {

    }

    [JsonObject("rail-signal", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RailSignal : EntityWithHealth
    {

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object[] _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object[] _CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("default_green_output_signal")]
        public string _DefaultGreenOutputSignal { get; set; }

        [JsonProperty("default_orange_output_signal")]
        public string _DefaultOrangeOutputSignal { get; set; }

        [JsonProperty("default_red_output_signal")]
        public string _DefaultRedOutputSignal { get; set; }

        [JsonProperty("green_light")]
        public object _GreenLight { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("orange_light")]
        public object _OrangeLight { get; set; }

        [JsonProperty("red_light")]
        public object _RedLight { get; set; }

    }

    [JsonObject("roboport", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Roboport : EntityWithHealth
    {

        [JsonProperty("base")]
        public object _Base { get; set; }

        [JsonProperty("base_animation")]
        public object _BaseAnimation { get; set; }

        [JsonProperty("base_patch")]
        public object _BasePatch { get; set; }

        [JsonProperty("charge_approach_distance")]
        public float _ChargeApproachDistance { get; set; }

        [JsonProperty("charging_energy")]
        public string _ChargingEnergy { get; set; }

        [JsonProperty("construction_radius")]
        public float _ConstructionRadius { get; set; }

        [JsonProperty("construction_radius_visualisation_picture")]
        public object _ConstructionRadiusVisualisationPicture { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("door_animation_down")]
        public object _DoorAnimationDown { get; set; }

        [JsonProperty("door_animation_up")]
        public object _DoorAnimationUp { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("logistics_radius")]
        public float _LogisticsRadius { get; set; }

        [JsonProperty("material_slots_count")]
        public float _MaterialSlotsCount { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("radius_visualisation_picture")]
        public object _RadiusVisualisationPicture { get; set; }

        [JsonProperty("recharge_minimum")]
        public string _RechargeMinimum { get; set; }

        [JsonProperty("recharging_animation")]
        public object _RechargingAnimation { get; set; }

        [JsonProperty("recharging_light")]
        public object _RechargingLight { get; set; }

        [JsonProperty("request_to_open_door_timeout")]
        public float _RequestToOpenDoorTimeout { get; set; }

        [JsonProperty("robot_slots_count")]
        public float _RobotSlotsCount { get; set; }

        [JsonProperty("spawn_and_station_height")]
        public float _SpawnAndStationHeight { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object _CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("close_door_trigger_effect")]
        public object[] _CloseDoorTriggerEffect { get; set; }

        [JsonProperty("default_available_construction_output_signal")]
        public string _DefaultAvailableConstructionOutputSignal { get; set; }

        [JsonProperty("default_available_logistic_output_signal")]
        public string _DefaultAvailableLogisticOutputSignal { get; set; }

        [JsonProperty("default_total_construction_output_signal")]
        public string _DefaultTotalConstructionOutputSignal { get; set; }

        [JsonProperty("default_total_logistic_output_signal")]
        public string _DefaultTotalLogisticOutputSignal { get; set; }

        [JsonProperty("open_door_trigger_effect")]
        public object[] _OpenDoorTriggerEffect { get; set; }

        [JsonProperty("stationing_offset")]
        public object[] _StationingOffset { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("charging_offsets")]
        public object[] _ChargingOffsets { get; set; }

        [JsonProperty("draw_construction_radius_visualization")]
        public bool _DrawConstructionRadiusVisualization { get; set; }

        [JsonProperty("draw_logistic_radius_visualization")]
        public bool _DrawLogisticRadiusVisualization { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("Prototype/Robot", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Robot : EntityWithHealth
    {

    }

    [JsonObject("combat-robot", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CombatRobot : Robot
    {

        [JsonProperty("attack_parameters")]
        public object _AttackParameters { get; set; }

        [JsonProperty("destroy_action")]
        public object _DestroyAction { get; set; }

        [JsonProperty("distance_per_frame")]
        public float _DistancePerFrame { get; set; }

        [JsonProperty("follows_player")]
        public bool _FollowsPlayer { get; set; }

        [JsonProperty("friction")]
        public float _Friction { get; set; }

        [JsonProperty("idle")]
        public object _Idle { get; set; }

        [JsonProperty("in_motion")]
        public object _InMotion { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("range_from_player")]
        public float _RangeFromPlayer { get; set; }

        [JsonProperty("shadow_idle")]
        public object _ShadowIdle { get; set; }

        [JsonProperty("shadow_in_motion")]
        public object _ShadowInMotion { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("time_to_live")]
        public float _TimeToLive { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("alert_when_damaged")]
        public bool _AlertWhenDamaged { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

    }

    [JsonObject("construction-robot", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConstructionRobot : Robot
    {

        [JsonProperty("cargo_centered")]
        public object[] _CargoCentered { get; set; }

        [JsonProperty("construction_vector")]
        public object[] _ConstructionVector { get; set; }

        [JsonProperty("energy_per_move")]
        public string _EnergyPerMove { get; set; }

        [JsonProperty("energy_per_tick")]
        public string _EnergyPerTick { get; set; }

        [JsonProperty("idle")]
        public object _Idle { get; set; }

        [JsonProperty("in_motion")]
        public object _InMotion { get; set; }

        [JsonProperty("max_energy")]
        public string _MaxEnergy { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("max_payload_size")]
        public float _MaxPayloadSize { get; set; }

        [JsonProperty("max_to_charge")]
        public float _MaxToCharge { get; set; }

        [JsonProperty("min_to_charge")]
        public float _MinToCharge { get; set; }

        [JsonProperty("repair_pack")]
        public string _RepairPack { get; set; }

        [JsonProperty("shadow_idle")]
        public object _ShadowIdle { get; set; }

        [JsonProperty("shadow_in_motion")]
        public object _ShadowInMotion { get; set; }

        [JsonProperty("shadow_working")]
        public object _ShadowWorking { get; set; }

        [JsonProperty("smoke")]
        public object _Smoke { get; set; }

        [JsonProperty("sparks")]
        public object[] _Sparks { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("speed_multiplier_when_out_of_energy")]
        public float _SpeedMultiplierWhenOutOfEnergy { get; set; }

        [JsonProperty("transfer_distance")]
        public float _TransferDistance { get; set; }

        [JsonProperty("working")]
        public object _Working { get; set; }

        [JsonProperty("working_light")]
        public object _WorkingLight { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

    }

    [JsonObject("logistic-robot", MemberSerialization = MemberSerialization.OptIn)]
    public partial class LogisticRobot : Robot
    {

        [JsonProperty("cargo_centered")]
        public object[] _CargoCentered { get; set; }

        [JsonProperty("energy_per_move")]
        public string _EnergyPerMove { get; set; }

        [JsonProperty("energy_per_tick")]
        public string _EnergyPerTick { get; set; }

        [JsonProperty("idle")]
        public object _Idle { get; set; }

        [JsonProperty("idle_with_cargo")]
        public object _IdleWithCargo { get; set; }

        [JsonProperty("in_motion")]
        public object _InMotion { get; set; }

        [JsonProperty("in_motion_with_cargo")]
        public object _InMotionWithCargo { get; set; }

        [JsonProperty("max_energy")]
        public string _MaxEnergy { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("max_payload_size")]
        public float _MaxPayloadSize { get; set; }

        [JsonProperty("max_to_charge")]
        public float _MaxToCharge { get; set; }

        [JsonProperty("min_to_charge")]
        public float _MinToCharge { get; set; }

        [JsonProperty("shadow_idle")]
        public object _ShadowIdle { get; set; }

        [JsonProperty("shadow_idle_with_cargo")]
        public object _ShadowIdleWithCargo { get; set; }

        [JsonProperty("shadow_in_motion")]
        public object _ShadowInMotion { get; set; }

        [JsonProperty("shadow_in_motion_with_cargo")]
        public object _ShadowInMotionWithCargo { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("speed_multiplier_when_out_of_energy")]
        public float _SpeedMultiplierWhenOutOfEnergy { get; set; }

        [JsonProperty("transfer_distance")]
        public float _TransferDistance { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

    }

    [JsonObject("rocket-defense", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RocketDefense : EntityWithHealth
    {

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

    }

    [JsonObject("solar-panel", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SolarPanel : EntityWithHealth
    {

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("picture")]
        public object _Picture { get; set; }

        [JsonProperty("production")]
        public string _Production { get; set; }

    }

    [JsonObject("splitter", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Splitter : EntityWithHealth
    {

        [JsonProperty("animation_speed_coefficient")]
        public float _AnimationSpeedCoefficient { get; set; }

        [JsonProperty("belt_horizontal")]
        public object _BeltHorizontal { get; set; }

        [JsonProperty("belt_vertical")]
        public object _BeltVertical { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("ending_bottom")]
        public object _EndingBottom { get; set; }

        [JsonProperty("ending_patch")]
        public object _EndingPatch { get; set; }

        [JsonProperty("ending_side")]
        public object _EndingSide { get; set; }

        [JsonProperty("ending_top")]
        public object _EndingTop { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("starting_bottom")]
        public object _StartingBottom { get; set; }

        [JsonProperty("starting_side")]
        public object _StartingSide { get; set; }

        [JsonProperty("starting_top")]
        public object _StartingTop { get; set; }

        [JsonProperty("structure")]
        public object _Structure { get; set; }

        [JsonProperty("structure_animation_movement_cooldown")]
        public float _StructureAnimationMovementCooldown { get; set; }

        [JsonProperty("structure_animation_speed_coefficient")]
        public float _StructureAnimationSpeedCoefficient { get; set; }

    }

    [JsonObject("train-stop", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TrainStop : EntityWithHealth
    {

        [JsonProperty("animation_ticks_per_frame")]
        public float _AnimationTicksPerFrame { get; set; }

        [JsonProperty("animations")]
        public object _Animations { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object[] _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object[] _CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("color")]
        public object _Color { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("drawing_boxes")]
        public object _DrawingBoxes { get; set; }

        [JsonProperty("light1")]
        public object _Light1 { get; set; }

        [JsonProperty("light2")]
        public object _Light2 { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("rail_overlay_animations")]
        public object _RailOverlayAnimations { get; set; }

        [JsonProperty("top_animations")]
        public object _TopAnimations { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("Prototype/TrainUnit", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TrainUnit : EntityWithHealth
    {

    }

    [JsonObject("cargo-wagon", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CargoWagon : TrainUnit
    {

        [JsonProperty("air_resistance")]
        public float _AirResistance { get; set; }

        [JsonProperty("back_light")]
        public object[] _BackLight { get; set; }

        [JsonProperty("braking_force")]
        public float _BrakingForce { get; set; }

        [JsonProperty("close_sound")]
        public object _CloseSound { get; set; }

        [JsonProperty("color")]
        public object _Color { get; set; }

        [JsonProperty("connection_distance")]
        public float _ConnectionDistance { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("crash_trigger")]
        public object _CrashTrigger { get; set; }

        [JsonProperty("drive_over_tie_trigger")]
        public object _DriveOverTieTrigger { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("energy_per_hit_point")]
        public float _EnergyPerHitPoint { get; set; }

        [JsonProperty("equipment_grid")]
        public string _EquipmentGrid { get; set; }

        [JsonProperty("friction_force")]
        public float _FrictionForce { get; set; }

        [JsonProperty("horizontal_doors")]
        public object _HorizontalDoors { get; set; }

        [JsonProperty("inventory_size")]
        public float _InventorySize { get; set; }

        [JsonProperty("joint_distance")]
        public float _JointDistance { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("max_speed")]
        public float _MaxSpeed { get; set; }

        [JsonProperty("mined_sound")]
        public object _MinedSound { get; set; }

        [JsonProperty("open_sound")]
        public object _OpenSound { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("rail_category")]
        public string _RailCategory { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("sound_minimum_speed")]
        public float _SoundMinimumSpeed { get; set; }

        [JsonProperty("stand_by_light")]
        public object[] _StandByLight { get; set; }

        [JsonProperty("tie_distance")]
        public float _TieDistance { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("vertical_doors")]
        public object _VerticalDoors { get; set; }

        [JsonProperty("vertical_selection_shift")]
        public float _VerticalSelectionShift { get; set; }

        [JsonProperty("wheels")]
        public object _Wheels { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("locomotive", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Locomotive : TrainUnit
    {

        [JsonProperty("air_resistance")]
        public float _AirResistance { get; set; }

        [JsonProperty("back_light")]
        public object[] _BackLight { get; set; }

        [JsonProperty("braking_force")]
        public float _BrakingForce { get; set; }

        [JsonProperty("close_sound")]
        public object _CloseSound { get; set; }

        [JsonProperty("color")]
        public object _Color { get; set; }

        [JsonProperty("connection_distance")]
        public float _ConnectionDistance { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("crash_trigger")]
        public object _CrashTrigger { get; set; }

        [JsonProperty("drive_over_tie_trigger")]
        public object _DriveOverTieTrigger { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("energy_per_hit_point")]
        public float _EnergyPerHitPoint { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("equipment_grid")]
        public string _EquipmentGrid { get; set; }

        [JsonProperty("friction_force")]
        public float _FrictionForce { get; set; }

        [JsonProperty("front_light")]
        public object[] _FrontLight { get; set; }

        [JsonProperty("joint_distance")]
        public float _JointDistance { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("max_power")]
        public string _MaxPower { get; set; }

        [JsonProperty("max_speed")]
        public float _MaxSpeed { get; set; }

        [JsonProperty("mined_sound")]
        public object _MinedSound { get; set; }

        [JsonProperty("open_sound")]
        public object _OpenSound { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("rail_category")]
        public string _RailCategory { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("reversing_power_modifier")]
        public float _ReversingPowerModifier { get; set; }

        [JsonProperty("sound_minimum_speed")]
        public float _SoundMinimumSpeed { get; set; }

        [JsonProperty("stand_by_light")]
        public object[] _StandByLight { get; set; }

        [JsonProperty("stop_trigger")]
        public object[] _StopTrigger { get; set; }

        [JsonProperty("tie_distance")]
        public float _TieDistance { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("vertical_selection_shift")]
        public float _VerticalSelectionShift { get; set; }

        [JsonProperty("wheels")]
        public object _Wheels { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("transport-belt", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TransportBelt : EntityWithHealth
    {

        [JsonProperty("animation_speed_coefficient")]
        public float _AnimationSpeedCoefficient { get; set; }

        [JsonProperty("animations")]
        public object _Animations { get; set; }

        [JsonProperty("belt_horizontal")]
        public object _BeltHorizontal { get; set; }

        [JsonProperty("belt_vertical")]
        public object _BeltVertical { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object _CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("connector_frame_sprites")]
        public object _ConnectorFrameSprites { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("ending_bottom")]
        public object _EndingBottom { get; set; }

        [JsonProperty("ending_patch")]
        public object _EndingPatch { get; set; }

        [JsonProperty("ending_side")]
        public object _EndingSide { get; set; }

        [JsonProperty("ending_top")]
        public object _EndingTop { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("starting_bottom")]
        public object _StartingBottom { get; set; }

        [JsonProperty("starting_side")]
        public object _StartingSide { get; set; }

        [JsonProperty("starting_top")]
        public object _StartingTop { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("transport-belt-to-ground", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TransportBeltToGround : EntityWithHealth
    {

    }

    [JsonObject("tree", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Tree : EntityWithHealth
    {

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("pictures")]
        public object[] _Pictures { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("colors")]
        public object[] _Colors { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("darkness_of_burnt_tree")]
        public float _DarknessOfBurntTree { get; set; }

        [JsonProperty("remains_when_mined")]
        public string _RemainsWhenMined { get; set; }

        [JsonProperty("variations")]
        public object[] _Variations { get; set; }

    }

    [JsonObject("turret", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Turret : EntityWithHealth
    {

        [JsonProperty("attack_parameters")]
        public object _AttackParameters { get; set; }

        [JsonProperty("build_base_evolution_requirement")]
        public float _BuildBaseEvolutionRequirement { get; set; }

        [JsonProperty("call_for_help_radius")]
        public float _CallForHelpRadius { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("dying_sound")]
        public object[] _DyingSound { get; set; }

        [JsonProperty("ending_attack_animation")]
        public object _EndingAttackAnimation { get; set; }

        [JsonProperty("ending_attack_speed")]
        public float _EndingAttackSpeed { get; set; }

        [JsonProperty("folded_animation")]
        public object _FoldedAnimation { get; set; }

        [JsonProperty("folded_speed")]
        public float _FoldedSpeed { get; set; }

        [JsonProperty("folding_animation")]
        public object _FoldingAnimation { get; set; }

        [JsonProperty("folding_speed")]
        public float _FoldingSpeed { get; set; }

        [JsonProperty("healing_per_tick")]
        public float _HealingPerTick { get; set; }

        [JsonProperty("inventory_size")]
        public float _InventorySize { get; set; }

        [JsonProperty("loot")]
        public object[] _Loot { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("prepare_range")]
        public float _PrepareRange { get; set; }

        [JsonProperty("prepared_animation")]
        public object _PreparedAnimation { get; set; }

        [JsonProperty("prepared_speed")]
        public float _PreparedSpeed { get; set; }

        [JsonProperty("preparing_animation")]
        public object _PreparingAnimation { get; set; }

        [JsonProperty("preparing_speed")]
        public float _PreparingSpeed { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("rotation_speed")]
        public float _RotationSpeed { get; set; }

        [JsonProperty("shooting_cursor_size")]
        public float _ShootingCursorSize { get; set; }

        [JsonProperty("starting_attack_animation")]
        public object _StartingAttackAnimation { get; set; }

        [JsonProperty("starting_attack_sound")]
        public object[] _StartingAttackSound { get; set; }

        [JsonProperty("starting_attack_speed")]
        public float _StartingAttackSpeed { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    [JsonObject("ammo-turret", MemberSerialization = MemberSerialization.OptIn)]
    public partial class AmmoTurret : Turret
    {

        [JsonProperty("attacking_animation")]
        public object _AttackingAnimation { get; set; }

        [JsonProperty("attacking_speed")]
        public float _AttackingSpeed { get; set; }

        [JsonProperty("automated_ammo_count")]
        public float _AutomatedAmmoCount { get; set; }

        [JsonProperty("base_picture")]
        public object _BasePicture { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("electric-turret", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ElectricTurret : Turret
    {

        [JsonProperty("base_picture")]
        public object _BasePicture { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("unit", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Unit : EntityWithHealth
    {

        [JsonProperty("attack_parameters")]
        public object _AttackParameters { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("distance_per_frame")]
        public float _DistancePerFrame { get; set; }

        [JsonProperty("distraction_cooldown")]
        public float _DistractionCooldown { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("dying_sound")]
        public object[] _DyingSound { get; set; }

        [JsonProperty("healing_per_tick")]
        public float _HealingPerTick { get; set; }

        [JsonProperty("loot")]
        public object[] _Loot { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("movement_speed")]
        public float _MovementSpeed { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("pollution_to_join_attack")]
        public float _PollutionToJoinAttack { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("run_animation")]
        public object _RunAnimation { get; set; }

        [JsonProperty("spawning_time_modifier")]
        public float _SpawningTimeModifier { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("vision_distance")]
        public float _VisionDistance { get; set; }

        [JsonProperty("working_sound")]
        public object[] _WorkingSound { get; set; }

    }

    [JsonObject("unit-spawner", MemberSerialization = MemberSerialization.OptIn)]
    public partial class UnitSpawner : EntityWithHealth
    {

        [JsonProperty("animations")]
        public object[] _Animations { get; set; }

        [JsonProperty("call_for_help_radius")]
        public float _CallForHelpRadius { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("dying_sound")]
        public object[] _DyingSound { get; set; }

        [JsonProperty("healing_per_tick")]
        public float _HealingPerTick { get; set; }

        [JsonProperty("loot")]
        public object[] _Loot { get; set; }

        [JsonProperty("max_count_of_owned_units")]
        public float _MaxCountOfOwnedUnits { get; set; }

        [JsonProperty("max_friends_around_to_spawn")]
        public float _MaxFriendsAroundToSpawn { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("max_richness_for_spawn_shift")]
        public float _MaxRichnessForSpawnShift { get; set; }

        [JsonProperty("max_spawn_shift")]
        public float _MaxSpawnShift { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("pollution_absorbtion_absolute")]
        public float _PollutionAbsorbtionAbsolute { get; set; }

        [JsonProperty("pollution_absorbtion_proportional")]
        public float _PollutionAbsorbtionProportional { get; set; }

        [JsonProperty("pollution_to_enhance_spawning")]
        public float _PollutionToEnhanceSpawning { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("result_units")]
        public object[] _ResultUnits { get; set; }

        [JsonProperty("spawning_cooldown")]
        public object[] _SpawningCooldown { get; set; }

        [JsonProperty("spawning_radius")]
        public float _SpawningRadius { get; set; }

        [JsonProperty("spawning_spacing")]
        public float _SpawningSpacing { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("wall", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Wall : EntityWithHealth
    {

        [JsonProperty("circuit_connector_sprites")]
        public object _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object _CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("connected_gate_visualization")]
        public object _ConnectedGateVisualization { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("default_output_signal")]
        public string _DefaultOutputSignal { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("mined_sound")]
        public object _MinedSound { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("repair_sound")]
        public object _RepairSound { get; set; }

        [JsonProperty("repair_speed_modifier")]
        public float _RepairSpeedModifier { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("wall_diode_green")]
        public object _WallDiodeGreen { get; set; }

        [JsonProperty("wall_diode_green_light")]
        public object _WallDiodeGreenLight { get; set; }

        [JsonProperty("wall_diode_red")]
        public object _WallDiodeRed { get; set; }

        [JsonProperty("wall_diode_red_light")]
        public object _WallDiodeRedLight { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("flying-text", MemberSerialization = MemberSerialization.OptIn)]
    public partial class FlyingText : Entity
    {

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("time_to_live")]
        public float _TimeToLive { get; set; }

    }

    [JsonObject("ghost", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Ghost : Entity
    {

    }

    [JsonObject("item-entity", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ItemEntity : Entity
    {

    }

    [JsonObject("land-mine", MemberSerialization = MemberSerialization.OptIn)]
    public partial class LandMine : Entity
    {

        [JsonProperty("action")]
        public object _Action { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("picture_safe")]
        public object _PictureSafe { get; set; }

        [JsonProperty("picture_set")]
        public object _PictureSet { get; set; }

        [JsonProperty("trigger_radius")]
        public float _TriggerRadius { get; set; }

    }

    [JsonObject("particle", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Particle : Entity
    {

        [JsonProperty("life_time")]
        public float _LifeTime { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("shadows")]
        public object _Shadows { get; set; }

        [JsonProperty("movement_modifier_when_on_ground")]
        public float _MovementModifierWhenOnGround { get; set; }

        [JsonProperty("ended_in_water_trigger_effect")]
        public object _EndedInWaterTriggerEffect { get; set; }

        [JsonProperty("regular_trigger_effect")]
        public object _RegularTriggerEffect { get; set; }

        [JsonProperty("regular_trigger_effect_frequency")]
        public float _RegularTriggerEffectFrequency { get; set; }

    }

    [JsonObject("projectile", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Projectile : Entity
    {

        [JsonProperty("acceleration")]
        public float _Acceleration { get; set; }

        [JsonProperty("action")]
        public object _Action { get; set; }

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("rotatable")]
        public bool _Rotatable { get; set; }

        [JsonProperty("shadow")]
        public object _Shadow { get; set; }

        [JsonProperty("direction_only")]
        public bool _DirectionOnly { get; set; }

        [JsonProperty("light")]
        public object _Light { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("smoke")]
        public object[] _Smoke { get; set; }

        [JsonProperty("final_action")]
        public object _FinalAction { get; set; }

        [JsonProperty("piercing_damage")]
        public float _PiercingDamage { get; set; }

    }

    [JsonObject("rail-remnants", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RailRemnants : Entity
    {

        [JsonProperty("bending_type")]
        public string _BendingType { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("selectable_in_game")]
        public bool _SelectableInGame { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("time_before_removed")]
        public float _TimeBeforeRemoved { get; set; }

        [JsonProperty("time_before_shading_off")]
        public float _TimeBeforeShadingOff { get; set; }

    }

    [JsonObject("resource", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Resource : Entity
    {

        [JsonProperty("map_color")]
        public object _MapColor { get; set; }

        [JsonProperty("minimum")]
        public float _Minimum { get; set; }

        [JsonProperty("normal")]
        public float _Normal { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("stage_counts")]
        public object[] _StageCounts { get; set; }

        [JsonProperty("stages")]
        public object _Stages { get; set; }

        [JsonProperty("category")]
        public string _Category { get; set; }

        [JsonProperty("infinite")]
        public bool _Infinite { get; set; }

        [JsonProperty("map_grid")]
        public bool _MapGrid { get; set; }

    }

    [JsonObject("smoke", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Smoke : Entity
    {

        [JsonProperty("affected_by_wind")]
        public bool _AffectedByWind { get; set; }

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("color")]
        public object _Color { get; set; }

        [JsonProperty("cyclic")]
        public bool _Cyclic { get; set; }

        [JsonProperty("duration")]
        public float _Duration { get; set; }

        [JsonProperty("end_scale")]
        public float _EndScale { get; set; }

        [JsonProperty("fade_away_duration")]
        public float _FadeAwayDuration { get; set; }

        [JsonProperty("spread_duration")]
        public float _SpreadDuration { get; set; }

        [JsonProperty("start_scale")]
        public float _StartScale { get; set; }

        [JsonProperty("fade_in_duration")]
        public float _FadeInDuration { get; set; }

        [JsonProperty("glow_animation")]
        public object _GlowAnimation { get; set; }

        [JsonProperty("glow_fade_away_duration")]
        public float _GlowFadeAwayDuration { get; set; }

        [JsonProperty("movement_slow_down_factor")]
        public float _MovementSlowDownFactor { get; set; }

        [JsonProperty("render_layer")]
        public string _RenderLayer { get; set; }

        [JsonProperty("show_when_smoke_off")]
        public bool _ShowWhenSmokeOff { get; set; }

    }

    [JsonObject("sticker", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Sticker : Entity
    {

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("damage_per_tick")]
        public object _DamagePerTick { get; set; }

        [JsonProperty("duration_in_ticks")]
        public float _DurationInTicks { get; set; }

        [JsonProperty("fire_spread_cooldown")]
        public float _FireSpreadCooldown { get; set; }

        [JsonProperty("fire_spread_radius")]
        public float _FireSpreadRadius { get; set; }

        [JsonProperty("spread_fire_entity")]
        public string _SpreadFireEntity { get; set; }

        [JsonProperty("target_movement_modifier")]
        public float _TargetMovementModifier { get; set; }

    }

    public partial class Item
    {

        [JsonProperty("default_request_amount")]
        public float _DefaultRequestAmount { get; set; }

        [JsonProperty("placed_as_equipment_result")]
        public string _PlacedAsEquipmentResult { get; set; }

        [JsonProperty("dark_background_icon")]
        public string _DarkBackgroundIcon { get; set; }

        [JsonProperty("place_as_tile")]
        public object _PlaceAsTile { get; set; }

        [JsonProperty("damage_radius")]
        public float _DamageRadius { get; set; }

        [JsonProperty("trigger_radius")]
        public float _TriggerRadius { get; set; }

    }

    [JsonObject("ammo", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Ammo : Item
    {

        [JsonProperty("ammo_type")]
        public object _AmmoType { get; set; }

        [JsonProperty("magazine_size")]
        public float _MagazineSize { get; set; }

    }

    [JsonObject("armor", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Armor : Item
    {

        [JsonProperty("durability")]
        public float _Durability { get; set; }

        [JsonProperty("equipment_grid")]
        public string _EquipmentGrid { get; set; }

        [JsonProperty("inventory_size_bonus")]
        public float _InventorySizeBonus { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

    }

    [JsonObject("capsule", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Capsule : Item
    {

        [JsonProperty("capsule_action")]
        public object _CapsuleAction { get; set; }

    }

    [JsonObject("Prototype/Equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Equipment : Item
    {

    }

    [JsonObject("night-vision-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class NightVisionEquipment : Equipment
    {

        [JsonProperty("categories")]
        public object[] _Categories { get; set; }

        [JsonProperty("energy_input")]
        public string _EnergyInput { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("shape")]
        public object _Shape { get; set; }

        [JsonProperty("sprite")]
        public object _Sprite { get; set; }

        [JsonProperty("tint")]
        public object _Tint { get; set; }

    }

    [JsonObject("energy-shield-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class EnergyShieldEquipment : Equipment
    {

        [JsonProperty("categories")]
        public object[] _Categories { get; set; }

        [JsonProperty("energy_per_shield")]
        public string _EnergyPerShield { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("max_shield_value")]
        public float _MaxShieldValue { get; set; }

        [JsonProperty("shape")]
        public object _Shape { get; set; }

        [JsonProperty("sprite")]
        public object _Sprite { get; set; }

    }

    [JsonObject("battery-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class BatteryEquipment : Equipment
    {

        [JsonProperty("categories")]
        public object[] _Categories { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("shape")]
        public object _Shape { get; set; }

        [JsonProperty("sprite")]
        public object _Sprite { get; set; }

    }

    [JsonObject("solar-panel-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SolarPanelEquipment : Equipment
    {

        [JsonProperty("categories")]
        public object[] _Categories { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("power")]
        public string _Power { get; set; }

        [JsonProperty("shape")]
        public object _Shape { get; set; }

        [JsonProperty("sprite")]
        public object _Sprite { get; set; }

    }

    [JsonObject("generator-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class GeneratorEquipment : Equipment
    {

        [JsonProperty("categories")]
        public object[] _Categories { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("power")]
        public string _Power { get; set; }

        [JsonProperty("shape")]
        public object _Shape { get; set; }

        [JsonProperty("sprite")]
        public object _Sprite { get; set; }

    }

    [JsonObject("active-defense-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ActiveDefenseEquipment : Equipment
    {

        [JsonProperty("attack_parameters")]
        public object _AttackParameters { get; set; }

        [JsonProperty("automatic")]
        public bool _Automatic { get; set; }

        [JsonProperty("categories")]
        public object[] _Categories { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("shape")]
        public object _Shape { get; set; }

        [JsonProperty("sprite")]
        public object _Sprite { get; set; }

        [JsonProperty("ability_icon")]
        public object _AbilityIcon { get; set; }

    }

    [JsonObject("movement-bonus-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class MovementBonusEquipment : Equipment
    {

        [JsonProperty("categories")]
        public object[] _Categories { get; set; }

        [JsonProperty("energy_consumption")]
        public string _EnergyConsumption { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("movement_bonus")]
        public float _MovementBonus { get; set; }

        [JsonProperty("shape")]
        public object _Shape { get; set; }

        [JsonProperty("sprite")]
        public object _Sprite { get; set; }

    }

    [JsonObject("gun", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Gun : Item
    {

        [JsonProperty("attack_parameters")]
        public object _AttackParameters { get; set; }

    }

    [JsonObject("mining-tool", MemberSerialization = MemberSerialization.OptIn)]
    public partial class MiningTool : Item
    {

        [JsonProperty("action")]
        public object _Action { get; set; }

        [JsonProperty("durability")]
        public float _Durability { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

    }

    [JsonObject("module", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Module : Item
    {

        [JsonProperty("category")]
        public string _Category { get; set; }

        [JsonProperty("effect")]
        public object _Effect { get; set; }

        [JsonProperty("tier")]
        public float _Tier { get; set; }

        [JsonProperty("limitation")]
        public object[] _Limitation { get; set; }

        [JsonProperty("limitation_message_key")]
        public string _LimitationMessageKey { get; set; }

    }

    public partial class ItemGroup
    {

        [JsonProperty("inventory_order")]
        public string _InventoryOrder { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

    }

    [JsonObject("map-settings", MemberSerialization = MemberSerialization.OptIn)]
    public partial class MapSettings : TypedNamedBase
    {

        [JsonProperty("attack")]
        public object _Attack { get; set; }

        [JsonProperty("enemy_evolution")]
        public object _EnemyEvolution { get; set; }

        [JsonProperty("enemy_expansion")]
        public object _EnemyExpansion { get; set; }

        [JsonProperty("max_failed_behavior_count")]
        public float _MaxFailedBehaviorCount { get; set; }

        [JsonProperty("path_finder")]
        public object _PathFinder { get; set; }

        [JsonProperty("pollution")]
        public object _Pollution { get; set; }

        [JsonProperty("steering")]
        public object _Steering { get; set; }

        [JsonProperty("unit_group")]
        public object _UnitGroup { get; set; }

    }

    [JsonObject("noise-layer", MemberSerialization = MemberSerialization.OptIn)]
    public partial class NoiseLayer : TypedNamedBase
    {

    }

    [JsonObject("rail-category", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RailCategory : TypedNamedBase
    {

    }

    public partial class Recipe
    {

        [JsonProperty("ingredients")]
        public object[] _Ingredients { get; set; }

        [JsonProperty("requester_paste_multiplier")]
        public float _RequesterPasteMultiplier { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("results")]
        public object[] _Results { get; set; }

        [JsonProperty("main_product")]
        public string _MainProduct { get; set; }

        [JsonProperty("hidden")]
        public object _Hidden { get; set; }

    }

    public partial class Technology
    {

        [JsonProperty("unit")]
        public object _Unit { get; set; }

        [JsonProperty("icon_size")]
        public float _IconSize { get; set; }

        [JsonProperty("upgrade")]
        public object _Upgrade { get; set; }

        [JsonProperty("localised_description")]
        public object[] _LocalisedDescription { get; set; }

        [JsonProperty("localised_name")]
        public object[] _LocalisedName { get; set; }

    }

    [JsonObject("tile", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Tile : TypedNamedBase
    {

        [JsonProperty("ageing")]
        public float _Ageing { get; set; }

        [JsonProperty("collision_mask")]
        public object[] _CollisionMask { get; set; }

        [JsonProperty("decorative_removal_probability")]
        public float _DecorativeRemovalProbability { get; set; }

        [JsonProperty("layer")]
        public float _Layer { get; set; }

        [JsonProperty("map_color")]
        public object _MapColor { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("mined_sound")]
        public object _MinedSound { get; set; }

        [JsonProperty("needs_correction")]
        public bool _NeedsCorrection { get; set; }

        [JsonProperty("variants")]
        public object _Variants { get; set; }

        [JsonProperty("vehicle_friction_modifier")]
        public float _VehicleFrictionModifier { get; set; }

        [JsonProperty("walking_sound")]
        public object[] _WalkingSound { get; set; }

        [JsonProperty("walking_speed_modifier")]
        public float _WalkingSpeedModifier { get; set; }

        [JsonProperty("allowed_neighbors")]
        public object[] _AllowedNeighbors { get; set; }

        [JsonProperty("autoplace")]
        public object _Autoplace { get; set; }

        [JsonProperty("can_be_part_of_blueprint")]
        public bool _CanBePartOfBlueprint { get; set; }

        [JsonProperty("next_direction")]
        public string _NextDirection { get; set; }

    }

    [JsonObject("achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Achievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

    }

    [JsonObject("ambient-sound", MemberSerialization = MemberSerialization.OptIn)]
    public partial class AmbientSound : TypedNamedBase
    {

        [JsonProperty("sound")]
        public object _Sound { get; set; }

        [JsonProperty("track_type")]
        public string _TrackType { get; set; }

    }

    [JsonObject("arithmetic-combinator", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ArithmeticCombinator : TypedNamedBase
    {

        [JsonProperty("active_energy_usage")]
        public string _ActiveEnergyUsage { get; set; }

        [JsonProperty("activity_led_light")]
        public object _ActivityLedLight { get; set; }

        [JsonProperty("activity_led_light_offsets")]
        public object[] _ActivityLedLightOffsets { get; set; }

        [JsonProperty("activity_led_sprites")]
        public object _ActivityLedSprites { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("divide_symbol_sprites")]
        public object _DivideSymbolSprites { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("input_connection_bounding_box")]
        public object[] _InputConnectionBoundingBox { get; set; }

        [JsonProperty("input_connection_points")]
        public object[] _InputConnectionPoints { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("minus_symbol_sprites")]
        public object _MinusSymbolSprites { get; set; }

        [JsonProperty("multiply_symbol_sprites")]
        public object _MultiplySymbolSprites { get; set; }

        [JsonProperty("output_connection_bounding_box")]
        public object[] _OutputConnectionBoundingBox { get; set; }

        [JsonProperty("output_connection_points")]
        public object[] _OutputConnectionPoints { get; set; }

        [JsonProperty("plus_symbol_sprites")]
        public object _PlusSymbolSprites { get; set; }

        [JsonProperty("screen_light")]
        public object _ScreenLight { get; set; }

        [JsonProperty("screen_light_offsets")]
        public object[] _ScreenLightOffsets { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("sprites")]
        public object _Sprites { get; set; }

    }

    [JsonObject("beam", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Beam : TypedNamedBase
    {

        [JsonProperty("action")]
        public object _Action { get; set; }

        [JsonProperty("body")]
        public object[] _Body { get; set; }

        [JsonProperty("damage_interval")]
        public float _DamageInterval { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("head")]
        public object _Head { get; set; }

        [JsonProperty("tail")]
        public object _Tail { get; set; }

        [JsonProperty("width")]
        public float _Width { get; set; }

        [JsonProperty("working_sound")]
        public object[] _WorkingSound { get; set; }

    }

    public partial class Blueprint
    {

        [JsonProperty("alt_selection_color")]
        public object _AltSelectionColor { get; set; }

        [JsonProperty("alt_selection_cursor_box_type")]
        public string _AltSelectionCursorBoxType { get; set; }

        [JsonProperty("alt_selection_mode")]
        public object[] _AltSelectionMode { get; set; }

        [JsonProperty("draw_label_for_cursor_render")]
        public bool _DrawLabelForCursorRender { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("item_to_clear")]
        public string _ItemToClear { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("selection_color")]
        public object _SelectionColor { get; set; }

        [JsonProperty("selection_cursor_box_type")]
        public string _SelectionCursorBoxType { get; set; }

        [JsonProperty("selection_mode")]
        public object[] _SelectionMode { get; set; }

        [JsonProperty("stack_size")]
        public float _StackSize { get; set; }

        [JsonProperty("stackable")]
        public bool _Stackable { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    public partial class BlueprintBook
    {

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("inventory_size")]
        public float _InventorySize { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("stack_size")]
        public float _StackSize { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    [JsonObject("build-entity-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class BuildEntityAchievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("to_build")]
        public string _ToBuild { get; set; }

        [JsonProperty("until_second")]
        public float _UntilSecond { get; set; }

    }

    [JsonObject("combat-robot-count", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CombatRobotCount : TypedNamedBase
    {

        [JsonProperty("count")]
        public float _Count { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string _SteamStatsName { get; set; }

    }

    [JsonObject("constant-combinator", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConstantCombinator : TypedNamedBase
    {

        [JsonProperty("activity_led_light")]
        public object _ActivityLedLight { get; set; }

        [JsonProperty("activity_led_light_offsets")]
        public object[] _ActivityLedLightOffsets { get; set; }

        [JsonProperty("activity_led_sprites")]
        public object _ActivityLedSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object[] _CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("item_slot_count")]
        public float _ItemSlotCount { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("sprites")]
        public object _Sprites { get; set; }

    }

    [JsonObject("construct-with-robots-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConstructWithRobotsAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float _Amount { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("limited_to_one_game")]
        public bool _LimitedToOneGame { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string _SteamStatsName { get; set; }

        [JsonProperty("more_than_manually")]
        public bool _MoreThanManually { get; set; }

    }

    [JsonObject("curved-rail", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CurvedRail : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("placeable_by")]
        public object _PlaceableBy { get; set; }

        [JsonProperty("rail_category")]
        public string _RailCategory { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("secondary_collision_box")]
        public object[] _SecondaryCollisionBox { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

    }

    [JsonObject("custom-input", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CustomInput : TypedNamedBase
    {

        [JsonProperty("consuming")]
        public string _Consuming { get; set; }

        [JsonProperty("key_sequence")]
        public string _KeySequence { get; set; }

    }

    [JsonObject("decider-combinator", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeciderCombinator : TypedNamedBase
    {

        [JsonProperty("active_energy_usage")]
        public string _ActiveEnergyUsage { get; set; }

        [JsonProperty("activity_led_light")]
        public object _ActivityLedLight { get; set; }

        [JsonProperty("activity_led_light_offsets")]
        public object[] _ActivityLedLightOffsets { get; set; }

        [JsonProperty("activity_led_sprites")]
        public object _ActivityLedSprites { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("equal_symbol_sprites")]
        public object _EqualSymbolSprites { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("greater_symbol_sprites")]
        public object _GreaterSymbolSprites { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("input_connection_bounding_box")]
        public object[] _InputConnectionBoundingBox { get; set; }

        [JsonProperty("input_connection_points")]
        public object[] _InputConnectionPoints { get; set; }

        [JsonProperty("less_symbol_sprites")]
        public object _LessSymbolSprites { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("output_connection_bounding_box")]
        public object[] _OutputConnectionBoundingBox { get; set; }

        [JsonProperty("output_connection_points")]
        public object[] _OutputConnectionPoints { get; set; }

        [JsonProperty("screen_light")]
        public object _ScreenLight { get; set; }

        [JsonProperty("screen_light_offsets")]
        public object[] _ScreenLightOffsets { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("sprites")]
        public object _Sprites { get; set; }

    }

    [JsonObject("deconstructible-tile-proxy", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeconstructibleTileProxy : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

    }

    public partial class DeconstructionItem
    {

        [JsonProperty("alt_selection_color")]
        public object _AltSelectionColor { get; set; }

        [JsonProperty("alt_selection_cursor_box_type")]
        public string _AltSelectionCursorBoxType { get; set; }

        [JsonProperty("alt_selection_mode")]
        public object[] _AltSelectionMode { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("selection_color")]
        public object _SelectionColor { get; set; }

        [JsonProperty("selection_cursor_box_type")]
        public string _SelectionCursorBoxType { get; set; }

        [JsonProperty("selection_mode")]
        public object[] _SelectionMode { get; set; }

        [JsonProperty("stack_size")]
        public float _StackSize { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    [JsonObject("deconstruct-with-robots-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeconstructWithRobotsAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float _Amount { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string _SteamStatsName { get; set; }

    }

    [JsonObject("deliver-by-robots-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeliverByRobotsAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float _Amount { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string _SteamStatsName { get; set; }

    }

    [JsonObject("dont-build-entity-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DontBuildEntityAchievement : TypedNamedBase
    {

        [JsonProperty("dont_build")]
        public object _DontBuild { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("allowed_in_peaceful_mode")]
        public bool _AllowedInPeacefulMode { get; set; }

    }

    [JsonObject("dont-craft-manually-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DontCraftManuallyAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float _Amount { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

    }

    [JsonObject("dont-use-entity-in-energy-production-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DontUseEntityInEnergyProductionAchievement : TypedNamedBase
    {

        [JsonProperty("excluded")]
        public string _Excluded { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("included")]
        public string _Included { get; set; }

        [JsonProperty("last_hour_only")]
        public bool _LastHourOnly { get; set; }

        [JsonProperty("minimum_energy_produced")]
        public string _MinimumEnergyProduced { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("allowed_in_peaceful_mode")]
        public bool _AllowedInPeacefulMode { get; set; }

    }

    [JsonObject("electric-energy-interface", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ElectricEnergyInterface : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("energy_production")]
        public string _EnergyProduction { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("picture")]
        public object _Picture { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("entity-ghost", MemberSerialization = MemberSerialization.OptIn)]
    public partial class EntityGhost : TypedNamedBase
    {

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

    }

    [JsonObject("equipment-category", MemberSerialization = MemberSerialization.OptIn)]
    public partial class EquipmentCategory : TypedNamedBase
    {

    }

    [JsonObject("equipment-grid", MemberSerialization = MemberSerialization.OptIn)]
    public partial class EquipmentGrid : TypedNamedBase
    {

        [JsonProperty("equipment_categories")]
        public object[] _EquipmentCategories { get; set; }

        [JsonProperty("height")]
        public float _Height { get; set; }

        [JsonProperty("width")]
        public float _Width { get; set; }

    }

    [JsonObject("finish-the-game-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class FinishTheGameAchievement : TypedNamedBase
    {

        [JsonProperty("allowed_in_peaceful_mode")]
        public bool _AllowedInPeacefulMode { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("until_second")]
        public float _UntilSecond { get; set; }

    }

    [JsonObject("fire", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Fire : TypedNamedBase
    {

        [JsonProperty("add_fuel_cooldown")]
        public float _AddFuelCooldown { get; set; }

        [JsonProperty("burnt_patch_alpha_default")]
        public float _BurntPatchAlphaDefault { get; set; }

        [JsonProperty("burnt_patch_alpha_variations")]
        public object[] _BurntPatchAlphaVariations { get; set; }

        [JsonProperty("burnt_patch_lifetime")]
        public float _BurntPatchLifetime { get; set; }

        [JsonProperty("burnt_patch_pictures")]
        public object[] _BurntPatchPictures { get; set; }

        [JsonProperty("color")]
        public object _Color { get; set; }

        [JsonProperty("damage_per_tick")]
        public object _DamagePerTick { get; set; }

        [JsonProperty("delay_between_initial_flames")]
        public float _DelayBetweenInitialFlames { get; set; }

        [JsonProperty("duration")]
        public float _Duration { get; set; }

        [JsonProperty("emissions_per_tick")]
        public float _EmissionsPerTick { get; set; }

        [JsonProperty("end_scale")]
        public float _EndScale { get; set; }

        [JsonProperty("fade_away_duration")]
        public float _FadeAwayDuration { get; set; }

        [JsonProperty("fade_in_duration")]
        public float _FadeInDuration { get; set; }

        [JsonProperty("fade_out_duration")]
        public float _FadeOutDuration { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("flame_alpha")]
        public float _FlameAlpha { get; set; }

        [JsonProperty("flame_alpha_deviation")]
        public float _FlameAlphaDeviation { get; set; }

        [JsonProperty("increase_duration_by")]
        public float _IncreaseDurationBy { get; set; }

        [JsonProperty("increase_duration_cooldown")]
        public float _IncreaseDurationCooldown { get; set; }

        [JsonProperty("initial_lifetime")]
        public float _InitialLifetime { get; set; }

        [JsonProperty("lifetime_increase_by")]
        public float _LifetimeIncreaseBy { get; set; }

        [JsonProperty("lifetime_increase_cooldown")]
        public float _LifetimeIncreaseCooldown { get; set; }

        [JsonProperty("light")]
        public object _Light { get; set; }

        [JsonProperty("maximum_spread_count")]
        public float _MaximumSpreadCount { get; set; }

        [JsonProperty("on_fuel_added_action")]
        public object _OnFuelAddedAction { get; set; }

        [JsonProperty("pictures")]
        public object[] _Pictures { get; set; }

        [JsonProperty("smoke")]
        public object[] _Smoke { get; set; }

        [JsonProperty("smoke_source_pictures")]
        public object[] _SmokeSourcePictures { get; set; }

        [JsonProperty("spawn_entity")]
        public string _SpawnEntity { get; set; }

        [JsonProperty("spread_delay")]
        public float _SpreadDelay { get; set; }

        [JsonProperty("spread_delay_deviation")]
        public float _SpreadDelayDeviation { get; set; }

        [JsonProperty("spread_duration")]
        public float _SpreadDuration { get; set; }

        [JsonProperty("start_scale")]
        public float _StartScale { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

        [JsonProperty("small_tree_fire_pictures")]
        public object[] _SmallTreeFirePictures { get; set; }

        [JsonProperty("smoke_fade_in_duration")]
        public float _SmokeFadeInDuration { get; set; }

        [JsonProperty("smoke_fade_out_duration")]
        public float _SmokeFadeOutDuration { get; set; }

        [JsonProperty("tree_dying_factor")]
        public float _TreeDyingFactor { get; set; }

    }

    public partial class Fluid
    {

        [JsonProperty("base_color")]
        public object _BaseColor { get; set; }

        [JsonProperty("default_temperature")]
        public float _DefaultTemperature { get; set; }

        [JsonProperty("flow_color")]
        public object _FlowColor { get; set; }

        [JsonProperty("flow_to_energy_ratio")]
        public float _FlowToEnergyRatio { get; set; }

        [JsonProperty("heat_capacity")]
        public string _HeatCapacity { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_temperature")]
        public float _MaxTemperature { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("pressure_to_speed_ratio")]
        public float _PressureToSpeedRatio { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    [JsonObject("fluid-turret", MemberSerialization = MemberSerialization.OptIn)]
    public partial class FluidTurret : TypedNamedBase
    {

        [JsonProperty("activation_buffer_ratio")]
        public float _ActivationBufferRatio { get; set; }

        [JsonProperty("attack_parameters")]
        public object _AttackParameters { get; set; }

        [JsonProperty("attacking_animation")]
        public object _AttackingAnimation { get; set; }

        [JsonProperty("attacking_animation_fade_out")]
        public float _AttackingAnimationFadeOut { get; set; }

        [JsonProperty("attacking_muzzle_animation_shift")]
        public object _AttackingMuzzleAnimationShift { get; set; }

        [JsonProperty("attacking_speed")]
        public float _AttackingSpeed { get; set; }

        [JsonProperty("automated_ammo_count")]
        public float _AutomatedAmmoCount { get; set; }

        [JsonProperty("base_picture")]
        public object _BasePicture { get; set; }

        [JsonProperty("base_picture_render_layer")]
        public string _BasePictureRenderLayer { get; set; }

        [JsonProperty("base_picture_secondary_draw_order")]
        public float _BasePictureSecondaryDrawOrder { get; set; }

        [JsonProperty("call_for_help_radius")]
        public float _CallForHelpRadius { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("ending_attack_animation")]
        public object _EndingAttackAnimation { get; set; }

        [JsonProperty("ending_attack_muzzle_animation_shift")]
        public object _EndingAttackMuzzleAnimationShift { get; set; }

        [JsonProperty("ending_attack_speed")]
        public float _EndingAttackSpeed { get; set; }

        [JsonProperty("enough_fuel_indicator_picture")]
        public object _EnoughFuelIndicatorPicture { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("fluid_box")]
        public object _FluidBox { get; set; }

        [JsonProperty("fluid_buffer_input_flow")]
        public float _FluidBufferInputFlow { get; set; }

        [JsonProperty("fluid_buffer_size")]
        public float _FluidBufferSize { get; set; }

        [JsonProperty("folded_animation")]
        public object _FoldedAnimation { get; set; }

        [JsonProperty("folded_muzzle_animation_shift")]
        public object _FoldedMuzzleAnimationShift { get; set; }

        [JsonProperty("folding_animation")]
        public object _FoldingAnimation { get; set; }

        [JsonProperty("folding_muzzle_animation_shift")]
        public object _FoldingMuzzleAnimationShift { get; set; }

        [JsonProperty("folding_speed")]
        public float _FoldingSpeed { get; set; }

        [JsonProperty("gun_animation_render_layer")]
        public string _GunAnimationRenderLayer { get; set; }

        [JsonProperty("gun_animation_secondary_draw_order")]
        public float _GunAnimationSecondaryDrawOrder { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("indicator_light")]
        public object _IndicatorLight { get; set; }

        [JsonProperty("inventory_size")]
        public float _InventorySize { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("muzzle_animation")]
        public object _MuzzleAnimation { get; set; }

        [JsonProperty("muzzle_light")]
        public object _MuzzleLight { get; set; }

        [JsonProperty("not_enough_fuel_indicator_picture")]
        public object _NotEnoughFuelIndicatorPicture { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("prepare_range")]
        public float _PrepareRange { get; set; }

        [JsonProperty("prepared_animation")]
        public object _PreparedAnimation { get; set; }

        [JsonProperty("prepared_muzzle_animation_shift")]
        public object _PreparedMuzzleAnimationShift { get; set; }

        [JsonProperty("preparing_animation")]
        public object _PreparingAnimation { get; set; }

        [JsonProperty("preparing_muzzle_animation_shift")]
        public object _PreparingMuzzleAnimationShift { get; set; }

        [JsonProperty("preparing_speed")]
        public float _PreparingSpeed { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("rotation_speed")]
        public float _RotationSpeed { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("shoot_in_prepare_state")]
        public bool _ShootInPrepareState { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("font", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Font : TypedNamedBase
    {

        [JsonProperty("from")]
        public string _From { get; set; }

        [JsonProperty("size")]
        public float _Size { get; set; }

        [JsonProperty("border")]
        public bool _Border { get; set; }

        [JsonProperty("border_color")]
        public object[] _BorderColor { get; set; }

    }

    [JsonObject("gate", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Gate : TypedNamedBase
    {

        [JsonProperty("activation_distance")]
        public float _ActivationDistance { get; set; }

        [JsonProperty("close_sound")]
        public object _CloseSound { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string _FastReplaceableGroup { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("horizontal_animation")]
        public object _HorizontalAnimation { get; set; }

        [JsonProperty("horizontal_base")]
        public object _HorizontalBase { get; set; }

        [JsonProperty("horizontal_rail_animation_left")]
        public object _HorizontalRailAnimationLeft { get; set; }

        [JsonProperty("horizontal_rail_animation_right")]
        public object _HorizontalRailAnimationRight { get; set; }

        [JsonProperty("horizontal_rail_base")]
        public object _HorizontalRailBase { get; set; }

        [JsonProperty("horizontal_rail_base_mask")]
        public object _HorizontalRailBaseMask { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("open_sound")]
        public object _OpenSound { get; set; }

        [JsonProperty("opening_speed")]
        public float _OpeningSpeed { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("timeout_to_close")]
        public float _TimeoutToClose { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("vertical_animation")]
        public object _VerticalAnimation { get; set; }

        [JsonProperty("vertical_base")]
        public object _VerticalBase { get; set; }

        [JsonProperty("vertical_rail_animation_left")]
        public object _VerticalRailAnimationLeft { get; set; }

        [JsonProperty("vertical_rail_animation_right")]
        public object _VerticalRailAnimationRight { get; set; }

        [JsonProperty("vertical_rail_base")]
        public object _VerticalRailBase { get; set; }

        [JsonProperty("vertical_rail_base_mask")]
        public object _VerticalRailBaseMask { get; set; }

        [JsonProperty("wall_patch")]
        public object _WallPatch { get; set; }

    }

    [JsonObject("group-attack-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupAttackAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float _Amount { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

    }

    [JsonObject("gui-style", MemberSerialization = MemberSerialization.OptIn)]
    public partial class GuiStyle : TypedNamedBase
    {

        [JsonProperty("ability_slot_style")]
        public object _AbilitySlotStyle { get; set; }

        [JsonProperty("achievement_card_progressbar_style")]
        public object _AchievementCardProgressbarStyle { get; set; }

        [JsonProperty("achievement_description_label_style")]
        public object _AchievementDescriptionLabelStyle { get; set; }

        [JsonProperty("achievement_failed_description_label_style")]
        public object _AchievementFailedDescriptionLabelStyle { get; set; }

        [JsonProperty("achievement_failed_reason_label_style")]
        public object _AchievementFailedReasonLabelStyle { get; set; }

        [JsonProperty("achievement_failed_title_label_style")]
        public object _AchievementFailedTitleLabelStyle { get; set; }

        [JsonProperty("achievement_locked_description_label_style")]
        public object _AchievementLockedDescriptionLabelStyle { get; set; }

        [JsonProperty("achievement_locked_progress_label_style")]
        public object _AchievementLockedProgressLabelStyle { get; set; }

        [JsonProperty("achievement_locked_title_label_style")]
        public object _AchievementLockedTitleLabelStyle { get; set; }

        [JsonProperty("achievement_notification_frame_style")]
        public object _AchievementNotificationFrameStyle { get; set; }

        [JsonProperty("achievement_percent_label_style")]
        public object _AchievementPercentLabelStyle { get; set; }

        [JsonProperty("achievement_pinned_card_progressbar_style")]
        public object _AchievementPinnedCardProgressbarStyle { get; set; }

        [JsonProperty("achievement_progressbar_style")]
        public object _AchievementProgressbarStyle { get; set; }

        [JsonProperty("achievement_title_label_style")]
        public object _AchievementTitleLabelStyle { get; set; }

        [JsonProperty("achievement_unlocked_description_label_style")]
        public object _AchievementUnlockedDescriptionLabelStyle { get; set; }

        [JsonProperty("achievement_unlocked_title_label_style")]
        public object _AchievementUnlockedTitleLabelStyle { get; set; }

        [JsonProperty("achievements_flow_style")]
        public object _AchievementsFlowStyle { get; set; }

        [JsonProperty("activity_bar_style")]
        public object _ActivityBarStyle { get; set; }

        [JsonProperty("als_button")]
        public object _AlsButton { get; set; }

        [JsonProperty("als_button_all")]
        public object _AlsButtonAll { get; set; }

        [JsonProperty("als_button_all_selected")]
        public object _AlsButtonAllSelected { get; set; }

        [JsonProperty("als_button_apc")]
        public object _AlsButtonApc { get; set; }

        [JsonProperty("als_button_apc_selected")]
        public object _AlsButtonApcSelected { get; set; }

        [JsonProperty("als_button_charging")]
        public object _AlsButtonCharging { get; set; }

        [JsonProperty("als_button_charging_selected")]
        public object _AlsButtonChargingSelected { get; set; }

        [JsonProperty("als_button_close")]
        public object _AlsButtonClose { get; set; }

        [JsonProperty("als_button_con")]
        public object _AlsButtonCon { get; set; }

        [JsonProperty("als_button_con_selected")]
        public object _AlsButtonConSelected { get; set; }

        [JsonProperty("als_button_confirm")]
        public object _AlsButtonConfirm { get; set; }

        [JsonProperty("als_button_count")]
        public object _AlsButtonCount { get; set; }

        [JsonProperty("als_button_count_selected")]
        public object _AlsButtonCountSelected { get; set; }

        [JsonProperty("als_button_delete")]
        public object _AlsButtonDelete { get; set; }

        [JsonProperty("als_button_delete_selected")]
        public object _AlsButtonDeleteSelected { get; set; }

        [JsonProperty("als_button_edit")]
        public object _AlsButtonEdit { get; set; }

        [JsonProperty("als_button_hidden")]
        public object _AlsButtonHidden { get; set; }

        [JsonProperty("als_button_info")]
        public object _AlsButtonInfo { get; set; }

        [JsonProperty("als_button_irc")]
        public object _AlsButtonIrc { get; set; }

        [JsonProperty("als_button_irc_selected")]
        public object _AlsButtonIrcSelected { get; set; }

        [JsonProperty("als_button_items")]
        public object _AlsButtonItems { get; set; }

        [JsonProperty("als_button_items_selected")]
        public object _AlsButtonItemsSelected { get; set; }

        [JsonProperty("als_button_location")]
        public object _AlsButtonLocation { get; set; }

        [JsonProperty("als_button_log")]
        public object _AlsButtonLog { get; set; }

        [JsonProperty("als_button_log_selected")]
        public object _AlsButtonLogSelected { get; set; }

        [JsonProperty("als_button_main_icon")]
        public object _AlsButtonMainIcon { get; set; }

        [JsonProperty("als_button_name")]
        public object _AlsButtonName { get; set; }

        [JsonProperty("als_button_name_selected")]
        public object _AlsButtonNameSelected { get; set; }

        [JsonProperty("als_button_port")]
        public object _AlsButtonPort { get; set; }

        [JsonProperty("als_button_port_selected")]
        public object _AlsButtonPortSelected { get; set; }

        [JsonProperty("als_button_pos")]
        public object _AlsButtonPos { get; set; }

        [JsonProperty("als_button_pos_selected")]
        public object _AlsButtonPosSelected { get; set; }

        [JsonProperty("als_button_position")]
        public object _AlsButtonPosition { get; set; }

        [JsonProperty("als_button_position_selected")]
        public object _AlsButtonPositionSelected { get; set; }

        [JsonProperty("als_button_ppc")]
        public object _AlsButtonPpc { get; set; }

        [JsonProperty("als_button_ppc_selected")]
        public object _AlsButtonPpcSelected { get; set; }

        [JsonProperty("als_button_rc")]
        public object _AlsButtonRc { get; set; }

        [JsonProperty("als_button_rc_selected")]
        public object _AlsButtonRcSelected { get; set; }

        [JsonProperty("als_button_sc")]
        public object _AlsButtonSc { get; set; }

        [JsonProperty("als_button_sc_selected")]
        public object _AlsButtonScSelected { get; set; }

        [JsonProperty("als_button_selected")]
        public object _AlsButtonSelected { get; set; }

        [JsonProperty("als_button_size")]
        public object _AlsButtonSize { get; set; }

        [JsonProperty("als_button_size_selected")]
        public object _AlsButtonSizeSelected { get; set; }

        [JsonProperty("als_button_small")]
        public object _AlsButtonSmall { get; set; }

        [JsonProperty("als_button_small_selected")]
        public object _AlsButtonSmallSelected { get; set; }

        [JsonProperty("als_button_stc")]
        public object _AlsButtonStc { get; set; }

        [JsonProperty("als_button_stc_selected")]
        public object _AlsButtonStcSelected { get; set; }

        [JsonProperty("als_button_teleport")]
        public object _AlsButtonTeleport { get; set; }

        [JsonProperty("als_button_total")]
        public object _AlsButtonTotal { get; set; }

        [JsonProperty("als_button_total_selected")]
        public object _AlsButtonTotalSelected { get; set; }

        [JsonProperty("als_button_up_apc")]
        public object _AlsButtonUpApc { get; set; }

        [JsonProperty("als_button_up_ppc")]
        public object _AlsButtonUpPpc { get; set; }

        [JsonProperty("als_button_up_rc")]
        public object _AlsButtonUpRc { get; set; }

        [JsonProperty("als_button_up_sc")]
        public object _AlsButtonUpSc { get; set; }

        [JsonProperty("als_button_waiting")]
        public object _AlsButtonWaiting { get; set; }

        [JsonProperty("als_button_waiting_selected")]
        public object _AlsButtonWaitingSelected { get; set; }

        [JsonProperty("als_button_woc")]
        public object _AlsButtonWoc { get; set; }

        [JsonProperty("als_button_woc_selected")]
        public object _AlsButtonWocSelected { get; set; }

        [JsonProperty("als_content_frame")]
        public object _AlsContentFrame { get; set; }

        [JsonProperty("als_filters_frame")]
        public object _AlsFiltersFrame { get; set; }

        [JsonProperty("als_flow_style")]
        public object _AlsFlowStyle { get; set; }

        [JsonProperty("als_frame")]
        public object _AlsFrame { get; set; }

        [JsonProperty("als_frame_hidden")]
        public object _AlsFrameHidden { get; set; }

        [JsonProperty("als_icon_flow")]
        public object _AlsIconFlow { get; set; }

        [JsonProperty("als_info_flow")]
        public object _AlsInfoFlow { get; set; }

        [JsonProperty("als_info_frame")]
        public object _AlsInfoFrame { get; set; }

        [JsonProperty("als_info_label")]
        public object _AlsInfoLabel { get; set; }

        [JsonProperty("als_item_icon")]
        public object _AlsItemIcon { get; set; }

        [JsonProperty("als_item_icon_selected")]
        public object _AlsItemIconSelected { get; set; }

        [JsonProperty("als_item_icon_small")]
        public object _AlsItemIconSmall { get; set; }

        [JsonProperty("als_item_icon_small_selected")]
        public object _AlsItemIconSmallSelected { get; set; }

        [JsonProperty("als_items_frame")]
        public object _AlsItemsFrame { get; set; }

        [JsonProperty("als_items_info_flow")]
        public object _AlsItemsInfoFlow { get; set; }

        [JsonProperty("als_items_table")]
        public object _AlsItemsTable { get; set; }

        [JsonProperty("als_location_view")]
        public object _AlsLocationView { get; set; }

        [JsonProperty("als_name_flow")]
        public object _AlsNameFlow { get; set; }

        [JsonProperty("als_network_filter_flow")]
        public object _AlsNetworkFilterFlow { get; set; }

        [JsonProperty("als_network_filter_hidden")]
        public object _AlsNetworkFilterHidden { get; set; }

        [JsonProperty("als_network_name_flow")]
        public object _AlsNetworkNameFlow { get; set; }

        [JsonProperty("als_network_name_hidden")]
        public object _AlsNetworkNameHidden { get; set; }

        [JsonProperty("als_network_value_flow")]
        public object _AlsNetworkValueFlow { get; set; }

        [JsonProperty("als_networks_frame")]
        public object _AlsNetworksFrame { get; set; }

        [JsonProperty("als_networks_table")]
        public object _AlsNetworksTable { get; set; }

        [JsonProperty("als_networks_table_wrapper")]
        public object _AlsNetworksTableWrapper { get; set; }

        [JsonProperty("als_pos_flow")]
        public object _AlsPosFlow { get; set; }

        [JsonProperty("als_search_frame")]
        public object _AlsSearchFrame { get; set; }

        [JsonProperty("als_search_frame_hidden")]
        public object _AlsSearchFrameHidden { get; set; }

        [JsonProperty("als_search_label")]
        public object _AlsSearchLabel { get; set; }

        [JsonProperty("als_searchfield_style")]
        public object _AlsSearchfieldStyle { get; set; }

        [JsonProperty("als_settings_info_label")]
        public object _AlsSettingsInfoLabel { get; set; }

        [JsonProperty("als_settings_table")]
        public object _AlsSettingsTable { get; set; }

        [JsonProperty("als_sort")]
        public object _AlsSort { get; set; }

        [JsonProperty("als_sort_asc")]
        public object _AlsSortAsc { get; set; }

        [JsonProperty("als_sort_desc")]
        public object _AlsSortDesc { get; set; }

        [JsonProperty("als_sort_flow")]
        public object _AlsSortFlow { get; set; }

        [JsonProperty("als_sort_holder")]
        public object _AlsSortHolder { get; set; }

        [JsonProperty("als_table_flow")]
        public object _AlsTableFlow { get; set; }

        [JsonProperty("als_title_label")]
        public object _AlsTitleLabel { get; set; }

        [JsonProperty("als_tools_flow")]
        public object _AlsToolsFlow { get; set; }

        [JsonProperty("als_total_flow")]
        public object _AlsTotalFlow { get; set; }

        [JsonProperty("als_total_w_flow")]
        public object _AlsTotalWFlow { get; set; }

        [JsonProperty("available_preview_technology_slot_style")]
        public object _AvailablePreviewTechnologySlotStyle { get; set; }

        [JsonProperty("available_technology_slot_style")]
        public object _AvailableTechnologySlotStyle { get; set; }

        [JsonProperty("battery_progressbar_style")]
        public object _BatteryProgressbarStyle { get; set; }

        [JsonProperty("bob-inserter-blank")]
        public object _BobInserterBlank { get; set; }

        [JsonProperty("bob-inserter-checkbox")]
        public object _BobInserterCheckbox { get; set; }

        [JsonProperty("bob-inserter-checkbox-drop")]
        public object _BobInserterCheckboxDrop { get; set; }

        [JsonProperty("bob-inserter-checkbox-pickup")]
        public object _BobInserterCheckboxPickup { get; set; }

        [JsonProperty("bob-inserter-checkbox-small")]
        public object _BobInserterCheckboxSmall { get; set; }

        [JsonProperty("bob-inserter-middle")]
        public object _BobInserterMiddle { get; set; }

        [JsonProperty("bob-logistics-checkbox")]
        public object _BobLogisticsCheckbox { get; set; }

        [JsonProperty("bob-logistics-inserter-button")]
        public object _BobLogisticsInserterButton { get; set; }

        [JsonProperty("bob-table")]
        public object _BobTable { get; set; }

        [JsonProperty("bold_label_style")]
        public object _BoldLabelStyle { get; set; }

        [JsonProperty("bonus_progressbar_style")]
        public object _BonusProgressbarStyle { get; set; }

        [JsonProperty("browse_games_gui_line_style")]
        public object _BrowseGamesGuiLineStyle { get; set; }

        [JsonProperty("browse_games_scroll_pane_style")]
        public object _BrowseGamesScrollPaneStyle { get; set; }

        [JsonProperty("browse_games_table_style")]
        public object _BrowseGamesTableStyle { get; set; }

        [JsonProperty("browse_mods_scroll_pane_style")]
        public object _BrowseModsScrollPaneStyle { get; set; }

        [JsonProperty("browse_mods_table_style")]
        public object _BrowseModsTableStyle { get; set; }

        [JsonProperty("burning_progressbar_style")]
        public object _BurningProgressbarStyle { get; set; }

        [JsonProperty("button_style")]
        public object _ButtonStyle { get; set; }

        [JsonProperty("campaign_levels_listbox_style")]
        public object _CampaignLevelsListboxStyle { get; set; }

        [JsonProperty("campaigns_listbox_style")]
        public object _CampaignsListboxStyle { get; set; }

        [JsonProperty("caption_label_style")]
        public object _CaptionLabelStyle { get; set; }

        [JsonProperty("checkbox_style")]
        public object _CheckboxStyle { get; set; }

        [JsonProperty("circuit_condition_sign_button_style")]
        public object _CircuitConditionSignButtonStyle { get; set; }

        [JsonProperty("console_input_textfield_style")]
        public object _ConsoleInputTextfieldStyle { get; set; }

        [JsonProperty("control_settings_table_style")]
        public object _ControlSettingsTableStyle { get; set; }

        [JsonProperty("controls_settings_button_style")]
        public object _ControlsSettingsButtonStyle { get; set; }

        [JsonProperty("crafting_queue_slot_style")]
        public object _CraftingQueueSlotStyle { get; set; }

        [JsonProperty("cursor_box")]
        public object _CursorBox { get; set; }

        [JsonProperty("custom_games_listbox_style")]
        public object _CustomGamesListboxStyle { get; set; }

        [JsonProperty("description_flow_style")]
        public object _DescriptionFlowStyle { get; set; }

        [JsonProperty("description_label_style")]
        public object _DescriptionLabelStyle { get; set; }

        [JsonProperty("description_remark_label_style")]
        public object _DescriptionRemarkLabelStyle { get; set; }

        [JsonProperty("description_title_label_style")]
        public object _DescriptionTitleLabelStyle { get; set; }

        [JsonProperty("description_value_label_style")]
        public object _DescriptionValueLabelStyle { get; set; }

        [JsonProperty("dialog_button_style")]
        public object _DialogButtonStyle { get; set; }

        [JsonProperty("disabled_technology_slot_style")]
        public object _DisabledTechnologySlotStyle { get; set; }

        [JsonProperty("downloading_mod_label_style")]
        public object _DownloadingModLabelStyle { get; set; }

        [JsonProperty("dropdown_style")]
        public object _DropdownStyle { get; set; }

        [JsonProperty("edit_label_button_style")]
        public object _EditLabelButtonStyle { get; set; }

        [JsonProperty("electric_network_sections_table_style")]
        public object _ElectricNetworkSectionsTableStyle { get; set; }

        [JsonProperty("electric_satisfaction_in_description_progressbar_style")]
        public object _ElectricSatisfactionInDescriptionProgressbarStyle { get; set; }

        [JsonProperty("electric_satisfaction_progressbar_style")]
        public object _ElectricSatisfactionProgressbarStyle { get; set; }

        [JsonProperty("electric_usage_label_style")]
        public object _ElectricUsageLabelStyle { get; set; }

        [JsonProperty("entity_info_label_style")]
        public object _EntityInfoLabelStyle { get; set; }

        [JsonProperty("failed_achievement_frame_style")]
        public object _FailedAchievementFrameStyle { get; set; }

        [JsonProperty("fake_disabled_button_style")]
        public object _FakeDisabledButtonStyle { get; set; }

        [JsonProperty("flip_button_style_left")]
        public object _FlipButtonStyleLeft { get; set; }

        [JsonProperty("flip_button_style_right")]
        public object _FlipButtonStyleRight { get; set; }

        [JsonProperty("floating_train_station_listbox_style")]
        public object _FloatingTrainStationListboxStyle { get; set; }

        [JsonProperty("flow_style")]
        public object _FlowStyle { get; set; }

        [JsonProperty("frame_caption_label_style")]
        public object _FrameCaptionLabelStyle { get; set; }

        [JsonProperty("frame_in_right_container_style")]
        public object _FrameInRightContainerStyle { get; set; }

        [JsonProperty("frame_style")]
        public object _FrameStyle { get; set; }

        [JsonProperty("goal_frame_style")]
        public object _GoalFrameStyle { get; set; }

        [JsonProperty("goal_label_style")]
        public object _GoalLabelStyle { get; set; }

        [JsonProperty("graph_style")]
        public object _GraphStyle { get; set; }

        [JsonProperty("green_circuit_network_content_slot_style")]
        public object _GreenCircuitNetworkContentSlotStyle { get; set; }

        [JsonProperty("green_slot_button_style")]
        public object _GreenSlotButtonStyle { get; set; }

        [JsonProperty("health_progressbar_style")]
        public object _HealthProgressbarStyle { get; set; }

        [JsonProperty("horizontal_line_style")]
        public object _HorizontalLineStyle { get; set; }

        [JsonProperty("image_tab_selected_slot_style")]
        public object _ImageTabSelectedSlotStyle { get; set; }

        [JsonProperty("image_tab_slot_style")]
        public object _ImageTabSlotStyle { get; set; }

        [JsonProperty("incompatible_mod_label_style")]
        public object _IncompatibleModLabelStyle { get; set; }

        [JsonProperty("inner_frame_in_outer_frame_style")]
        public object _InnerFrameInOuterFrameStyle { get; set; }

        [JsonProperty("inner_frame_style")]
        public object _InnerFrameStyle { get; set; }

        [JsonProperty("installed_mod_label_style")]
        public object _InstalledModLabelStyle { get; set; }

        [JsonProperty("invalid_label_style")]
        public object _InvalidLabelStyle { get; set; }

        [JsonProperty("label_style")]
        public object _LabelStyle { get; set; }

        [JsonProperty("listbox_item_style")]
        public object _ListboxItemStyle { get; set; }

        [JsonProperty("listbox_style")]
        public object _ListboxStyle { get; set; }

        [JsonProperty("load_game_mod_disabled_listbox_item_style")]
        public object _LoadGameModDisabledListboxItemStyle { get; set; }

        [JsonProperty("load_game_mod_invalid_listbox_item_style")]
        public object _LoadGameModInvalidListboxItemStyle { get; set; }

        [JsonProperty("load_game_mods_listbox_style")]
        public object _LoadGameModsListboxStyle { get; set; }

        [JsonProperty("locked_achievement_frame_style")]
        public object _LockedAchievementFrameStyle { get; set; }

        [JsonProperty("logistic_button_selected_slot_style")]
        public object _LogisticButtonSelectedSlotStyle { get; set; }

        [JsonProperty("logistic_button_slot_style")]
        public object _LogisticButtonSlotStyle { get; set; }

        [JsonProperty("machine_frame_style")]
        public object _MachineFrameStyle { get; set; }

        [JsonProperty("machine_right_part_flow_style")]
        public object _MachineRightPartFlowStyle { get; set; }

        [JsonProperty("map_settings_dropdown_style")]
        public object _MapSettingsDropdownStyle { get; set; }

        [JsonProperty("menu_button_style")]
        public object _MenuButtonStyle { get; set; }

        [JsonProperty("menu_frame_style")]
        public object _MenuFrameStyle { get; set; }

        [JsonProperty("menu_message_style")]
        public object _MenuMessageStyle { get; set; }

        [JsonProperty("minimap_frame_style")]
        public object _MinimapFrameStyle { get; set; }

        [JsonProperty("mining_progressbar_style")]
        public object _MiningProgressbarStyle { get; set; }

        [JsonProperty("mod_dependency_flow_style")]
        public object _ModDependencyFlowStyle { get; set; }

        [JsonProperty("mod_dependency_invalid_label_style")]
        public object _ModDependencyInvalidLabelStyle { get; set; }

        [JsonProperty("mod_disabled_listbox_item_style")]
        public object _ModDisabledListboxItemStyle { get; set; }

        [JsonProperty("mod_info_flow_style")]
        public object _ModInfoFlowStyle { get; set; }

        [JsonProperty("mod_invalid_listbox_item_style")]
        public object _ModInvalidListboxItemStyle { get; set; }

        [JsonProperty("mod_list_label_style")]
        public object _ModListLabelStyle { get; set; }

        [JsonProperty("mod_updates_available_listbox_item_style")]
        public object _ModUpdatesAvailableListboxItemStyle { get; set; }

        [JsonProperty("mods_listbox_style")]
        public object _ModsListboxStyle { get; set; }

        [JsonProperty("multiplayer_activity_bar_style")]
        public object _MultiplayerActivityBarStyle { get; set; }

        [JsonProperty("naked_frame_style")]
        public object _NakedFrameStyle { get; set; }

        [JsonProperty("no_path_station_in_schedule_in_train_view_listbox_item_style")]
        public object _NoPathStationInScheduleInTrainViewListboxItemStyle { get; set; }

        [JsonProperty("not_available_preview_technology_slot_style")]
        public object _NotAvailablePreviewTechnologySlotStyle { get; set; }

        [JsonProperty("not_available_slot_button_style")]
        public object _NotAvailableSlotButtonStyle { get; set; }

        [JsonProperty("not_available_technology_slot_style")]
        public object _NotAvailableTechnologySlotStyle { get; set; }

        [JsonProperty("not_working_weapon_button_style")]
        public object _NotWorkingWeaponButtonStyle { get; set; }

        [JsonProperty("notice_textbox_style")]
        public object _NoticeTextboxStyle { get; set; }

        [JsonProperty("number_textfield_style")]
        public object _NumberTextfieldStyle { get; set; }

        [JsonProperty("omitted_technology_slot_style")]
        public object _OmittedTechnologySlotStyle { get; set; }

        [JsonProperty("out_of_date_mod_label_style")]
        public object _OutOfDateModLabelStyle { get; set; }

        [JsonProperty("outer_frame_style")]
        public object _OuterFrameStyle { get; set; }

        [JsonProperty("partially_promised_crafting_queue_slot_style")]
        public object _PartiallyPromisedCraftingQueueSlotStyle { get; set; }

        [JsonProperty("player_listbox_item_style")]
        public object _PlayerListboxItemStyle { get; set; }

        [JsonProperty("production_progressbar_style")]
        public object _ProductionProgressbarStyle { get; set; }

        [JsonProperty("progressbar_style")]
        public object _ProgressbarStyle { get; set; }

        [JsonProperty("promised_crafting_queue_slot_style")]
        public object _PromisedCraftingQueueSlotStyle { get; set; }

        [JsonProperty("quick_bar_frame_style")]
        public object _QuickBarFrameStyle { get; set; }

        [JsonProperty("radiobutton_style")]
        public object _RadiobuttonStyle { get; set; }

        [JsonProperty("recipe_tooltip_cannot_craft_label_style")]
        public object _RecipeTooltipCannotCraftLabelStyle { get; set; }

        [JsonProperty("recipe_tooltip_transitive_craft_label_style")]
        public object _RecipeTooltipTransitiveCraftLabelStyle { get; set; }

        [JsonProperty("red_circuit_network_content_slot_style")]
        public object _RedCircuitNetworkContentSlotStyle { get; set; }

        [JsonProperty("red_slot_button_style")]
        public object _RedSlotButtonStyle { get; set; }

        [JsonProperty("researched_preview_technology_slot_style")]
        public object _ResearchedPreviewTechnologySlotStyle { get; set; }

        [JsonProperty("researched_technology_slot_style")]
        public object _ResearchedTechnologySlotStyle { get; set; }

        [JsonProperty("right_bottom_container_frame_style")]
        public object _RightBottomContainerFrameStyle { get; set; }

        [JsonProperty("right_container_frame_style")]
        public object _RightContainerFrameStyle { get; set; }

        [JsonProperty("saves_listbox_style")]
        public object _SavesListboxStyle { get; set; }

        [JsonProperty("scenario_message_dialog_label_style")]
        public object _ScenarioMessageDialogLabelStyle { get; set; }

        [JsonProperty("scenario_message_dialog_style")]
        public object _ScenarioMessageDialogStyle { get; set; }

        [JsonProperty("schedule_in_train_view_list_box_style")]
        public object _ScheduleInTrainViewListBoxStyle { get; set; }

        [JsonProperty("scroll_pane_style")]
        public object _ScrollPaneStyle { get; set; }

        [JsonProperty("scrollbar_style")]
        public object _ScrollbarStyle { get; set; }

        [JsonProperty("search_button_style")]
        public object _SearchButtonStyle { get; set; }

        [JsonProperty("search_flow_style")]
        public object _SearchFlowStyle { get; set; }

        [JsonProperty("search_mods_button_style")]
        public object _SearchModsButtonStyle { get; set; }

        [JsonProperty("search_textfield_style")]
        public object _SearchTextfieldStyle { get; set; }

        [JsonProperty("selected_slot_button_style")]
        public object _SelectedSlotButtonStyle { get; set; }

        [JsonProperty("shield_progressbar_style")]
        public object _ShieldProgressbarStyle { get; set; }

        [JsonProperty("side_menu_button_style")]
        public object _SideMenuButtonStyle { get; set; }

        [JsonProperty("side_menu_frame_style")]
        public object _SideMenuFrameStyle { get; set; }

        [JsonProperty("slider_style")]
        public object _SliderStyle { get; set; }

        [JsonProperty("slot_button_style")]
        public object _SlotButtonStyle { get; set; }

        [JsonProperty("slot_table_spacing_flow_style")]
        public object _SlotTableSpacingFlowStyle { get; set; }

        [JsonProperty("slot_table_style")]
        public object _SlotTableStyle { get; set; }

        [JsonProperty("slot_with_filter_button_style")]
        public object _SlotWithFilterButtonStyle { get; set; }

        [JsonProperty("small_slot_button_style")]
        public object _SmallSlotButtonStyle { get; set; }

        [JsonProperty("statistics_progressbar_style")]
        public object _StatisticsProgressbarStyle { get; set; }

        [JsonProperty("steam_friend_listbox_item_style")]
        public object _SteamFriendListboxItemStyle { get; set; }

        [JsonProperty("switch_quickbar_button_style")]
        public object _SwitchQuickbarButtonStyle { get; set; }

        [JsonProperty("tab_style")]
        public object _TabStyle { get; set; }

        [JsonProperty("table_spacing_flow_style")]
        public object _TableSpacingFlowStyle { get; set; }

        [JsonProperty("table_style")]
        public object _TableStyle { get; set; }

        [JsonProperty("target_station_in_schedule_in_train_view_listbox_item_style")]
        public object _TargetStationInScheduleInTrainViewListboxItemStyle { get; set; }

        [JsonProperty("technology_preview_frame_style")]
        public object _TechnologyPreviewFrameStyle { get; set; }

        [JsonProperty("technology_slot_button_style")]
        public object _TechnologySlotButtonStyle { get; set; }

        [JsonProperty("textbox_style")]
        public object _TextboxStyle { get; set; }

        [JsonProperty("textfield_style")]
        public object _TextfieldStyle { get; set; }

        [JsonProperty("to_be_downloaded_mod_label_style")]
        public object _ToBeDownloadedModLabelStyle { get; set; }

        [JsonProperty("tool_bar_frame_style")]
        public object _ToolBarFrameStyle { get; set; }

        [JsonProperty("tool_equip_gui_label_style")]
        public object _ToolEquipGuiLabelStyle { get; set; }

        [JsonProperty("tooltip_description_label_style")]
        public object _TooltipDescriptionLabelStyle { get; set; }

        [JsonProperty("tooltip_flow_style")]
        public object _TooltipFlowStyle { get; set; }

        [JsonProperty("tooltip_frame_style")]
        public object _TooltipFrameStyle { get; set; }

        [JsonProperty("tooltip_label_style")]
        public object _TooltipLabelStyle { get; set; }

        [JsonProperty("tooltip_title_label_style")]
        public object _TooltipTitleLabelStyle { get; set; }

        [JsonProperty("tracked_achievements_flow_style")]
        public object _TrackedAchievementsFlowStyle { get; set; }

        [JsonProperty("tracking_off_button_style")]
        public object _TrackingOffButtonStyle { get; set; }

        [JsonProperty("tracking_on_button_style")]
        public object _TrackingOnButtonStyle { get; set; }

        [JsonProperty("train_station_listbox_style")]
        public object _TrainStationListboxStyle { get; set; }

        [JsonProperty("train_station_schedule_listbox_style")]
        public object _TrainStationScheduleListboxStyle { get; set; }

        [JsonProperty("unlocked_achievement_frame_style")]
        public object _UnlockedAchievementFrameStyle { get; set; }

        [JsonProperty("vehicle_health_progressbar_style")]
        public object _VehicleHealthProgressbarStyle { get; set; }

        [JsonProperty("working_weapon_button_style")]
        public object _WorkingWeaponButtonStyle { get; set; }

    }

    [JsonObject("item-request-proxy", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ItemRequestProxy : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("picture")]
        public object _Picture { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

    }

    public partial class ItemSubgroup
    {

        [JsonProperty("order")]
        public string _Order { get; set; }

    }

    public partial class ItemWithEntityData 
    {

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("place_result")]
        public string _PlaceResult { get; set; }

        [JsonProperty("stack_size")]
        public float _StackSize { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("default_request_amount")]
        public float _DefaultRequestAmount { get; set; }

    }

    [JsonObject("kill-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class KillAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float _Amount { get; set; }

        [JsonProperty("damage_type")]
        public string _DamageType { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string _SteamStatsName { get; set; }

        [JsonProperty("type_to_kill")]
        public string _TypeToKill { get; set; }

        [JsonProperty("in_vehicle")]
        public bool _InVehicle { get; set; }

        [JsonProperty("personally")]
        public bool _Personally { get; set; }

    }

    [JsonObject("leaf-particle", MemberSerialization = MemberSerialization.OptIn)]
    public partial class LeafParticle : TypedNamedBase
    {

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("life_time")]
        public float _LifeTime { get; set; }

        [JsonProperty("movement_modifier")]
        public float _MovementModifier { get; set; }

        [JsonProperty("pictures")]
        public object[] _Pictures { get; set; }

        [JsonProperty("shadows")]
        public object[] _Shadows { get; set; }

    }

    [JsonObject("loader", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Loader : TypedNamedBase
    {

        [JsonProperty("animation_speed_coefficient")]
        public float _AnimationSpeedCoefficient { get; set; }

        [JsonProperty("belt_horizontal")]
        public object _BeltHorizontal { get; set; }

        [JsonProperty("belt_vertical")]
        public object _BeltVertical { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("ending_bottom")]
        public object _EndingBottom { get; set; }

        [JsonProperty("ending_patch")]
        public object _EndingPatch { get; set; }

        [JsonProperty("ending_side")]
        public object _EndingSide { get; set; }

        [JsonProperty("ending_top")]
        public object _EndingTop { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string _FastReplaceableGroup { get; set; }

        [JsonProperty("filter_count")]
        public float _FilterCount { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("starting_bottom")]
        public object _StartingBottom { get; set; }

        [JsonProperty("starting_side")]
        public object _StartingSide { get; set; }

        [JsonProperty("starting_top")]
        public object _StartingTop { get; set; }

        [JsonProperty("structure")]
        public object _Structure { get; set; }

    }

    [JsonObject("module-category", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ModuleCategory : TypedNamedBase
    {

    }

    [JsonObject("offshore-pump", MemberSerialization = MemberSerialization.OptIn)]
    public partial class OffshorePump : TypedNamedBase
    {

        [JsonProperty("circuit_connector_sprites")]
        public object[] _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object[] _CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("fluid")]
        public string _Fluid { get; set; }

        [JsonProperty("fluid_box")]
        public object _FluidBox { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("picture")]
        public object _Picture { get; set; }

        [JsonProperty("pumping_speed")]
        public float _PumpingSpeed { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("tile_width")]
        public float _TileWidth { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("particle-source", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ParticleSource : TypedNamedBase
    {

        [JsonProperty("height")]
        public float _Height { get; set; }

        [JsonProperty("height_deviation")]
        public float _HeightDeviation { get; set; }

        [JsonProperty("horizontal_speed")]
        public float _HorizontalSpeed { get; set; }

        [JsonProperty("horizontal_speed_deviation")]
        public float _HorizontalSpeedDeviation { get; set; }

        [JsonProperty("particle")]
        public string _Particle { get; set; }

        [JsonProperty("time_before_start")]
        public float _TimeBeforeStart { get; set; }

        [JsonProperty("time_before_start_deviation")]
        public float _TimeBeforeStartDeviation { get; set; }

        [JsonProperty("time_to_live")]
        public float _TimeToLive { get; set; }

        [JsonProperty("time_to_live_deviation")]
        public float _TimeToLiveDeviation { get; set; }

        [JsonProperty("vertical_speed")]
        public float _VerticalSpeed { get; set; }

        [JsonProperty("vertical_speed_deviation")]
        public float _VerticalSpeedDeviation { get; set; }

    }

    [JsonObject("player-damaged-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlayerDamagedAchievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("minimum_damage")]
        public float _MinimumDamage { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("should_survive")]
        public bool _ShouldSurvive { get; set; }

        [JsonProperty("steam_stats_name")]
        public string _SteamStatsName { get; set; }

        [JsonProperty("type_of_dealer")]
        public string _TypeOfDealer { get; set; }

    }

    [JsonObject("power-switch", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PowerSwitch : TypedNamedBase
    {

        [JsonProperty("circuit_wire_connection_point")]
        public object _CircuitWireConnectionPoint { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("led_off")]
        public object _LedOff { get; set; }

        [JsonProperty("led_on")]
        public object _LedOn { get; set; }

        [JsonProperty("left_wire_connection_point")]
        public object _LeftWireConnectionPoint { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("overlay_loop")]
        public object _OverlayLoop { get; set; }

        [JsonProperty("overlay_start")]
        public object _OverlayStart { get; set; }

        [JsonProperty("overlay_start_delay")]
        public float _OverlayStartDelay { get; set; }

        [JsonProperty("power_on_animation")]
        public object _PowerOnAnimation { get; set; }

        [JsonProperty("right_wire_connection_point")]
        public object _RightWireConnectionPoint { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("wire_max_distance")]
        public float _WireMaxDistance { get; set; }

    }

    [JsonObject("produce-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ProduceAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float _Amount { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("item_product")]
        public string _ItemProduct { get; set; }

        [JsonProperty("limited_to_one_game")]
        public bool _LimitedToOneGame { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string _SteamStatsName { get; set; }

    }

    [JsonObject("produce-per-hour-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ProducePerHourAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float _Amount { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("item_product")]
        public string _ItemProduct { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string _SteamStatsName { get; set; }

    }

    [JsonObject("rail-chain-signal", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RailChainSignal : TypedNamedBase
    {

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("blue_light")]
        public object _BlueLight { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string _FastReplaceableGroup { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("green_light")]
        public object _GreenLight { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("orange_light")]
        public object _OrangeLight { get; set; }

        [JsonProperty("rail_piece")]
        public object _RailPiece { get; set; }

        [JsonProperty("red_light")]
        public object _RedLight { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("selection_box_offsets")]
        public object[] _SelectionBoxOffsets { get; set; }

    }

    public partial class RailPlanner
    {

        [JsonProperty("curved_rail")]
        public string _CurvedRail { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("place_result")]
        public string _PlaceResult { get; set; }

        [JsonProperty("stack_size")]
        public float _StackSize { get; set; }

        [JsonProperty("straight_rail")]
        public string _StraightRail { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    public partial class RepairTool
    {

        [JsonProperty("durability")]
        public float _Durability { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("stack_size")]
        public float _StackSize { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    [JsonObject("research-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ResearchAchievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("technology")]
        public string _Technology { get; set; }

        [JsonProperty("research_all")]
        public bool _ResearchAll { get; set; }

    }

    [JsonObject("resource-category", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ResourceCategory : TypedNamedBase
    {

    }

    [JsonObject("roboport-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RoboportEquipment : TypedNamedBase
    {

        [JsonProperty("categories")]
        public object[] _Categories { get; set; }

        [JsonProperty("charge_approach_distance")]
        public float _ChargeApproachDistance { get; set; }

        [JsonProperty("charging_distance")]
        public float _ChargingDistance { get; set; }

        [JsonProperty("charging_energy")]
        public string _ChargingEnergy { get; set; }

        [JsonProperty("charging_station_count")]
        public float _ChargingStationCount { get; set; }

        [JsonProperty("charging_station_shift")]
        public object[] _ChargingStationShift { get; set; }

        [JsonProperty("charging_threshold_distance")]
        public float _ChargingThresholdDistance { get; set; }

        [JsonProperty("construction_radius")]
        public float _ConstructionRadius { get; set; }

        [JsonProperty("energy_consumption")]
        public string _EnergyConsumption { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("recharging_animation")]
        public object _RechargingAnimation { get; set; }

        [JsonProperty("recharging_light")]
        public object _RechargingLight { get; set; }

        [JsonProperty("robot_limit")]
        public float _RobotLimit { get; set; }

        [JsonProperty("shape")]
        public object _Shape { get; set; }

        [JsonProperty("spawn_and_station_height")]
        public float _SpawnAndStationHeight { get; set; }

        [JsonProperty("sprite")]
        public object _Sprite { get; set; }

        [JsonProperty("stationing_offset")]
        public object[] _StationingOffset { get; set; }

        [JsonProperty("take_result")]
        public string _TakeResult { get; set; }

    }

    public partial class RocketSilo 
    {

        [JsonProperty("active_energy_usage")]
        public string _ActiveEnergyUsage { get; set; }

        [JsonProperty("alarm_trigger")]
        public object[] _AlarmTrigger { get; set; }

        [JsonProperty("allowed_effects")]
        public object[] _AllowedEffects { get; set; }

        [JsonProperty("arm_01_back_animation")]
        public object _Arm01BackAnimation { get; set; }

        [JsonProperty("arm_02_right_animation")]
        public object _Arm02RightAnimation { get; set; }

        [JsonProperty("arm_03_front_animation")]
        public object _Arm03FrontAnimation { get; set; }

        [JsonProperty("base_day_sprite")]
        public object _BaseDaySprite { get; set; }

        [JsonProperty("base_engine_light")]
        public object _BaseEngineLight { get; set; }

        [JsonProperty("base_front_sprite")]
        public object _BaseFrontSprite { get; set; }

        [JsonProperty("base_light")]
        public object[] _BaseLight { get; set; }

        [JsonProperty("base_night_sprite")]
        public object _BaseNightSprite { get; set; }

        [JsonProperty("clamps_off_trigger")]
        public object[] _ClampsOffTrigger { get; set; }

        [JsonProperty("clamps_on_trigger")]
        public object[] _ClampsOnTrigger { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("crafting_categories")]
        public object[] _CraftingCategories { get; set; }

        [JsonProperty("crafting_speed")]
        public float _CraftingSpeed { get; set; }

        [JsonProperty("door_back_open_offset")]
        public object[] _DoorBackOpenOffset { get; set; }

        [JsonProperty("door_back_sprite")]
        public object _DoorBackSprite { get; set; }

        [JsonProperty("door_front_open_offset")]
        public object[] _DoorFrontOpenOffset { get; set; }

        [JsonProperty("door_front_sprite")]
        public object _DoorFrontSprite { get; set; }

        [JsonProperty("door_opening_speed")]
        public float _DoorOpeningSpeed { get; set; }

        [JsonProperty("doors_trigger")]
        public object[] _DoorsTrigger { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object _EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string _EnergyUsage { get; set; }

        [JsonProperty("fixed_recipe")]
        public string _FixedRecipe { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("hole_light_sprite")]
        public object _HoleLightSprite { get; set; }

        [JsonProperty("hole_sprite")]
        public object _HoleSprite { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("idle_energy_usage")]
        public string _IdleEnergyUsage { get; set; }

        [JsonProperty("ingredient_count")]
        public float _IngredientCount { get; set; }

        [JsonProperty("lamp_energy_usage")]
        public string _LampEnergyUsage { get; set; }

        [JsonProperty("light_blinking_speed")]
        public float _LightBlinkingSpeed { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("module_specification")]
        public object _ModuleSpecification { get; set; }

        [JsonProperty("raise_rocket_trigger")]
        public object[] _RaiseRocketTrigger { get; set; }

        [JsonProperty("red_lights_back_sprites")]
        public object _RedLightsBackSprites { get; set; }

        [JsonProperty("red_lights_front_sprites")]
        public object _RedLightsFrontSprites { get; set; }

        [JsonProperty("rocket_entity")]
        public string _RocketEntity { get; set; }

        [JsonProperty("rocket_glow_overlay_sprite")]
        public object _RocketGlowOverlaySprite { get; set; }

        [JsonProperty("rocket_parts_required")]
        public float _RocketPartsRequired { get; set; }

        [JsonProperty("rocket_shadow_overlay_sprite")]
        public object _RocketShadowOverlaySprite { get; set; }

        [JsonProperty("satellite_animation")]
        public object _SatelliteAnimation { get; set; }

        [JsonProperty("satellite_shadow_animation")]
        public object _SatelliteShadowAnimation { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("shadow_sprite")]
        public object _ShadowSprite { get; set; }

        [JsonProperty("silo_fade_out_end_distance")]
        public float _SiloFadeOutEndDistance { get; set; }

        [JsonProperty("silo_fade_out_start_distance")]
        public float _SiloFadeOutStartDistance { get; set; }

        [JsonProperty("times_to_blink")]
        public float _TimesToBlink { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

    }

    [JsonObject("rocket-silo-rocket", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RocketSiloRocket : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("collision_mask")]
        public object[] _CollisionMask { get; set; }

        [JsonProperty("dying_explosion")]
        public string _DyingExplosion { get; set; }

        [JsonProperty("effects_fade_in_end_distance")]
        public float _EffectsFadeInEndDistance { get; set; }

        [JsonProperty("effects_fade_in_start_distance")]
        public float _EffectsFadeInStartDistance { get; set; }

        [JsonProperty("engine_starting_speed")]
        public float _EngineStartingSpeed { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("flying_acceleration")]
        public float _FlyingAcceleration { get; set; }

        [JsonProperty("flying_speed")]
        public float _FlyingSpeed { get; set; }

        [JsonProperty("flying_trigger")]
        public object[] _FlyingTrigger { get; set; }

        [JsonProperty("full_render_layer_switch_distance")]
        public float _FullRenderLayerSwitchDistance { get; set; }

        [JsonProperty("glow_light")]
        public object _GlowLight { get; set; }

        [JsonProperty("inventory_size")]
        public float _InventorySize { get; set; }

        [JsonProperty("rising_speed")]
        public float _RisingSpeed { get; set; }

        [JsonProperty("rocket_flame_animation")]
        public object _RocketFlameAnimation { get; set; }

        [JsonProperty("rocket_flame_left_animation")]
        public object _RocketFlameLeftAnimation { get; set; }

        [JsonProperty("rocket_flame_left_rotation")]
        public float _RocketFlameLeftRotation { get; set; }

        [JsonProperty("rocket_flame_right_animation")]
        public object _RocketFlameRightAnimation { get; set; }

        [JsonProperty("rocket_flame_right_rotation")]
        public float _RocketFlameRightRotation { get; set; }

        [JsonProperty("rocket_glare_overlay_sprite")]
        public object _RocketGlareOverlaySprite { get; set; }

        [JsonProperty("rocket_launch_offset")]
        public object[] _RocketLaunchOffset { get; set; }

        [JsonProperty("rocket_render_layer_switch_distance")]
        public float _RocketRenderLayerSwitchDistance { get; set; }

        [JsonProperty("rocket_rise_offset")]
        public object[] _RocketRiseOffset { get; set; }

        [JsonProperty("rocket_shadow_sprite")]
        public object _RocketShadowSprite { get; set; }

        [JsonProperty("rocket_smoke_bottom1_animation")]
        public object _RocketSmokeBottom1Animation { get; set; }

        [JsonProperty("rocket_smoke_bottom2_animation")]
        public object _RocketSmokeBottom2Animation { get; set; }

        [JsonProperty("rocket_smoke_top1_animation")]
        public object _RocketSmokeTop1Animation { get; set; }

        [JsonProperty("rocket_smoke_top2_animation")]
        public object _RocketSmokeTop2Animation { get; set; }

        [JsonProperty("rocket_smoke_top3_animation")]
        public object _RocketSmokeTop3Animation { get; set; }

        [JsonProperty("rocket_sprite")]
        public object _RocketSprite { get; set; }

        [JsonProperty("rocket_visible_distance_from_center")]
        public float _RocketVisibleDistanceFromCenter { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("shadow_fade_out_end_ratio")]
        public float _ShadowFadeOutEndRatio { get; set; }

        [JsonProperty("shadow_fade_out_start_ratio")]
        public float _ShadowFadeOutStartRatio { get; set; }

        [JsonProperty("shadow_slave_entity")]
        public string _ShadowSlaveEntity { get; set; }

    }

    [JsonObject("rocket-silo-rocket-shadow", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RocketSiloRocketShadow : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("collision_mask")]
        public object[] _CollisionMask { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

    }

    [JsonObject("selection-tool", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SelectionTool : TypedNamedBase
    {

        [JsonProperty("alt_selection_color")]
        public object _AltSelectionColor { get; set; }

        [JsonProperty("alt_selection_cursor_box_type")]
        public string _AltSelectionCursorBoxType { get; set; }

        [JsonProperty("alt_selection_mode")]
        public object[] _AltSelectionMode { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("localised_name")]
        public object[] _LocalisedName { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("selection_color")]
        public object _SelectionColor { get; set; }

        [JsonProperty("selection_cursor_box_type")]
        public string _SelectionCursorBoxType { get; set; }

        [JsonProperty("selection_mode")]
        public object[] _SelectionMode { get; set; }

        [JsonProperty("stack_size")]
        public float _StackSize { get; set; }

        [JsonProperty("stackable")]
        public bool _Stackable { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    [JsonObject("simple-entity", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SimpleEntity : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("pictures")]
        public object[] _Pictures { get; set; }

        [JsonProperty("render_layer")]
        public string _RenderLayer { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("autoplace")]
        public object _Autoplace { get; set; }

        [JsonProperty("loot")]
        public object[] _Loot { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("mined_sound")]
        public object _MinedSound { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

    }

    [JsonObject("smoke-with-trigger", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SmokeWithTrigger : TypedNamedBase
    {

        [JsonProperty("action")]
        public object _Action { get; set; }

        [JsonProperty("action_frequency")]
        public float _ActionFrequency { get; set; }

        [JsonProperty("affected_by_wind")]
        public bool _AffectedByWind { get; set; }

        [JsonProperty("animation")]
        public object _Animation { get; set; }

        [JsonProperty("color")]
        public object _Color { get; set; }

        [JsonProperty("cyclic")]
        public bool _Cyclic { get; set; }

        [JsonProperty("duration")]
        public float _Duration { get; set; }

        [JsonProperty("fade_away_duration")]
        public float _FadeAwayDuration { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("show_when_smoke_off")]
        public bool _ShowWhenSmokeOff { get; set; }

        [JsonProperty("slow_down_factor")]
        public float _SlowDownFactor { get; set; }

        [JsonProperty("spread_duration")]
        public float _SpreadDuration { get; set; }

    }

    [JsonObject("storage-tank", MemberSerialization = MemberSerialization.OptIn)]
    public partial class StorageTank : TypedNamedBase
    {

        [JsonProperty("circuit_connector_sprites")]
        public object[] _CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object[] _CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float _CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string _FastReplaceableGroup { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("flow_length_in_ticks")]
        public float _FlowLengthInTicks { get; set; }

        [JsonProperty("fluid_box")]
        public object _FluidBox { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object _VehicleImpactSound { get; set; }

        [JsonProperty("window_bounding_box")]
        public object[] _WindowBoundingBox { get; set; }

        [JsonProperty("working_sound")]
        public object _WorkingSound { get; set; }

    }

    [JsonObject("straight-rail", MemberSerialization = MemberSerialization.OptIn)]
    public partial class StraightRail : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("pictures")]
        public object _Pictures { get; set; }

        [JsonProperty("rail_category")]
        public string _RailCategory { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

    }

    [JsonObject("stream", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Stream : TypedNamedBase
    {

        [JsonProperty("action")]
        public object[] _Action { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("ground_light")]
        public object _GroundLight { get; set; }

        [JsonProperty("particle")]
        public object _Particle { get; set; }

        [JsonProperty("particle_buffer_size")]
        public float _ParticleBufferSize { get; set; }

        [JsonProperty("particle_end_alpha")]
        public float _ParticleEndAlpha { get; set; }

        [JsonProperty("particle_fade_out_threshold")]
        public float _ParticleFadeOutThreshold { get; set; }

        [JsonProperty("particle_horizontal_speed")]
        public float _ParticleHorizontalSpeed { get; set; }

        [JsonProperty("particle_horizontal_speed_deviation")]
        public float _ParticleHorizontalSpeedDeviation { get; set; }

        [JsonProperty("particle_loop_exit_threshold")]
        public float _ParticleLoopExitThreshold { get; set; }

        [JsonProperty("particle_loop_frame_count")]
        public float _ParticleLoopFrameCount { get; set; }

        [JsonProperty("particle_spawn_interval")]
        public float _ParticleSpawnInterval { get; set; }

        [JsonProperty("particle_spawn_timeout")]
        public float _ParticleSpawnTimeout { get; set; }

        [JsonProperty("particle_start_alpha")]
        public float _ParticleStartAlpha { get; set; }

        [JsonProperty("particle_start_scale")]
        public float _ParticleStartScale { get; set; }

        [JsonProperty("particle_vertical_acceleration")]
        public float _ParticleVerticalAcceleration { get; set; }

        [JsonProperty("shadow")]
        public object _Shadow { get; set; }

        [JsonProperty("smoke_sources")]
        public object[] _SmokeSources { get; set; }

        [JsonProperty("spine_animation")]
        public object _SpineAnimation { get; set; }

        [JsonProperty("stream_light")]
        public object _StreamLight { get; set; }

        [JsonProperty("working_sound_disabled")]
        public object[] _WorkingSoundDisabled { get; set; }

    }

    [JsonObject("tile-ghost", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TileGhost : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

    }

    public partial class Tool
    {

        [JsonProperty("durability")]
        public float _Durability { get; set; }

        [JsonProperty("durability_description_key")]
        public string _DurabilityDescriptionKey { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("stack_size")]
        public float _StackSize { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

    }

    [JsonObject("train-path-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TrainPathAchievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("minimum_distance")]
        public float _MinimumDistance { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string _SteamStatsName { get; set; }

    }

    [JsonObject("underground-belt", MemberSerialization = MemberSerialization.OptIn)]
    public partial class UndergroundBelt : TypedNamedBase
    {

        [JsonProperty("animation_speed_coefficient")]
        public float _AnimationSpeedCoefficient { get; set; }

        [JsonProperty("belt_horizontal")]
        public object _BeltHorizontal { get; set; }

        [JsonProperty("belt_vertical")]
        public object _BeltVertical { get; set; }

        [JsonProperty("collision_box")]
        public object[] _CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string _Corpse { get; set; }

        [JsonProperty("ending_bottom")]
        public object _EndingBottom { get; set; }

        [JsonProperty("ending_patch")]
        public object _EndingPatch { get; set; }

        [JsonProperty("ending_side")]
        public object _EndingSide { get; set; }

        [JsonProperty("ending_top")]
        public object _EndingTop { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string _FastReplaceableGroup { get; set; }

        [JsonProperty("flags")]
        public object[] _Flags { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("max_distance")]
        public float _MaxDistance { get; set; }

        [JsonProperty("max_health")]
        public float _MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object _Minable { get; set; }

        [JsonProperty("resistances")]
        public object[] _Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object[] _SelectionBox { get; set; }

        [JsonProperty("speed")]
        public float _Speed { get; set; }

        [JsonProperty("starting_bottom")]
        public object _StartingBottom { get; set; }

        [JsonProperty("starting_side")]
        public object _StartingSide { get; set; }

        [JsonProperty("starting_top")]
        public object _StartingTop { get; set; }

        [JsonProperty("structure")]
        public object _Structure { get; set; }

        [JsonProperty("underground_sprite")]
        public object _UndergroundSprite { get; set; }

        [JsonProperty("distance_to_enter")]
        public float _DistanceToEnter { get; set; }

    }

    [JsonObject("utility-sprites", MemberSerialization = MemberSerialization.OptIn)]
    public partial class UtilitySprites : TypedNamedBase
    {

        [JsonProperty("arrow_button")]
        public object _ArrowButton { get; set; }

        [JsonProperty("battery_indicator")]
        public object _BatteryIndicator { get; set; }

        [JsonProperty("fluid_indication_arrow")]
        public object _FluidIndicationArrow { get; set; }

        [JsonProperty("grey_placement_indicator_leg")]
        public object _GreyPlacementIndicatorLeg { get; set; }

        [JsonProperty("grey_rail_signal_placement_indicator")]
        public object _GreyRailSignalPlacementIndicator { get; set; }

        [JsonProperty("indication_arrow")]
        public object _IndicationArrow { get; set; }

        [JsonProperty("indication_line")]
        public object _IndicationLine { get; set; }

        [JsonProperty("placement_indicator_leg")]
        public object _PlacementIndicatorLeg { get; set; }

        [JsonProperty("rail_planner_indication_arrow")]
        public object _RailPlannerIndicationArrow { get; set; }

        [JsonProperty("rail_planner_indication_arrow_too_far")]
        public object _RailPlannerIndicationArrowTooFar { get; set; }

        [JsonProperty("rail_signal_placement_indicator")]
        public object _RailSignalPlacementIndicator { get; set; }

        [JsonProperty("reset")]
        public object _Reset { get; set; }

        [JsonProperty("short_indication_line")]
        public object _ShortIndicationLine { get; set; }

        [JsonProperty("train_stop_placement_indicator")]
        public object _TrainStopPlacementIndicator { get; set; }

    }

    [JsonObject("virtual-signal", MemberSerialization = MemberSerialization.OptIn)]
    public partial class VirtualSignal : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("special_signal")]
        public bool _SpecialSignal { get; set; }

    }

}
