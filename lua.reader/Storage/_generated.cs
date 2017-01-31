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
        public string Order { get; set; }

        [JsonProperty("richness")]
        public bool Richness { get; set; }

    }

    [JsonObject("damage-type", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DamageType : TypedNamedBase
    {

    }

    [JsonObject("arrow", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Arrow : Entity
    {

        [JsonProperty("arrow_picture")]
        public object ArrowPicture { get; set; }

        [JsonProperty("blinking")]
        public bool Blinking { get; set; }

        [JsonProperty("circle_picture")]
        public object CirclePicture { get; set; }

    }

    [JsonObject("corpse", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Corpse : Entity
    {

        [JsonProperty("final_render_layer")]
        public string FinalRenderLayer { get; set; }

        [JsonProperty("splash")]
        public object Splash { get; set; }

        [JsonProperty("splash_speed")]
        public float SplashSpeed { get; set; }

        [JsonProperty("time_before_removed")]
        public float TimeBeforeRemoved { get; set; }

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("dying_speed")]
        public float DyingSpeed { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("selectable_in_game")]
        public bool SelectableInGame { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("collision_mask")]
        public object CollisionMask { get; set; }

        [JsonProperty("ground_patch")]
        public object GroundPatch { get; set; }

        [JsonProperty("ground_patch_higher")]
        public object GroundPatchHigher { get; set; }

    }

    [JsonObject("decorative", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Decorative : Entity
    {

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("render_layer")]
        public string RenderLayer { get; set; }

        [JsonProperty("selectable_in_game")]
        public bool SelectableInGame { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("explosion", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Explosion : Entity
    {

        [JsonProperty("animations")]
        public object Animations { get; set; }

        [JsonProperty("created_effect")]
        public object CreatedEffect { get; set; }

        [JsonProperty("light")]
        public object Light { get; set; }

        [JsonProperty("sound")]
        public object Sound { get; set; }

        [JsonProperty("smoke")]
        public string Smoke { get; set; }

        [JsonProperty("smoke_count")]
        public float SmokeCount { get; set; }

        [JsonProperty("smoke_slow_down_factor")]
        public float SmokeSlowDownFactor { get; set; }

        [JsonProperty("rotate")]
        public bool Rotate { get; set; }

        [JsonProperty("animation_speed")]
        public float AnimationSpeed { get; set; }

        [JsonProperty("beam")]
        public bool Beam { get; set; }

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
        public object ChargeAnimation { get; set; }

        [JsonProperty("charge_cooldown")]
        public float ChargeCooldown { get; set; }

        [JsonProperty("charge_light")]
        public object ChargeLight { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("default_output_signal")]
        public string DefaultOutputSignal { get; set; }

        [JsonProperty("discharge_animation")]
        public object DischargeAnimation { get; set; }

        [JsonProperty("discharge_cooldown")]
        public float DischargeCooldown { get; set; }

        [JsonProperty("discharge_light")]
        public object DischargeLight { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("picture")]
        public object Picture { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("assembling-machine", MemberSerialization = MemberSerialization.OptIn)]
    public partial class AssemblingMachine : EntityWithHealth
    {

        [JsonProperty("allowed_effects")]
        public object AllowedEffects { get; set; }

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("crafting_categories")]
        public object CraftingCategories { get; set; }

        [JsonProperty("crafting_speed")]
        public float CraftingSpeed { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string EnergyUsage { get; set; }

        [JsonProperty("fluid_boxes")]
        public object FluidBoxes { get; set; }

        [JsonProperty("ingredient_count")]
        public float IngredientCount { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("module_specification")]
        public object ModuleSpecification { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("close_sound")]
        public object CloseSound { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("open_sound")]
        public object OpenSound { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

        [JsonProperty("working_visualisations")]
        public object WorkingVisualisations { get; set; }

        [JsonProperty("mined_sound")]
        public object MinedSound { get; set; }

        [JsonProperty("repair_sound")]
        public object RepairSound { get; set; }

        [JsonProperty("has_backer_name")]
        public bool HasBackerName { get; set; }

        [JsonProperty("pipe_covers")]
        public object PipeCovers { get; set; }

    }

    [JsonObject("beacon", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Beacon : EntityWithHealth
    {

        [JsonProperty("allowed_effects")]
        public object AllowedEffects { get; set; }

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("animation_shadow")]
        public object AnimationShadow { get; set; }

        [JsonProperty("base_picture")]
        public object BasePicture { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("distribution_effectivity")]
        public float DistributionEffectivity { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string EnergyUsage { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("module_specification")]
        public object ModuleSpecification { get; set; }

        [JsonProperty("radius_visualisation_picture")]
        public object RadiusVisualisationPicture { get; set; }

        [JsonProperty("supply_area_distance")]
        public float SupplyAreaDistance { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("car", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Car : EntityWithHealth
    {

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("braking_power")]
        public string BrakingPower { get; set; }

        [JsonProperty("burner")]
        public object Burner { get; set; }

        [JsonProperty("close_sound")]
        public object CloseSound { get; set; }

        [JsonProperty("consumption")]
        public string Consumption { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("crash_trigger")]
        public object CrashTrigger { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("effectivity")]
        public float Effectivity { get; set; }

        [JsonProperty("energy_per_hit_point")]
        public float EnergyPerHitPoint { get; set; }

        [JsonProperty("friction")]
        public float Friction { get; set; }

        [JsonProperty("guns")]
        public object Guns { get; set; }

        [JsonProperty("inventory_size")]
        public float InventorySize { get; set; }

        [JsonProperty("light")]
        public object Light { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("open_sound")]
        public object OpenSound { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("rotation_speed")]
        public float RotationSpeed { get; set; }

        [JsonProperty("sound_minimum_speed")]
        public float SoundMinimumSpeed { get; set; }

        [JsonProperty("sound_no_fuel")]
        public object SoundNoFuel { get; set; }

        [JsonProperty("stop_trigger")]
        public object StopTrigger { get; set; }

        [JsonProperty("stop_trigger_speed")]
        public float StopTriggerSpeed { get; set; }

        [JsonProperty("turret_animation")]
        public object TurretAnimation { get; set; }

        [JsonProperty("turret_rotation_speed")]
        public float TurretRotationSpeed { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

        [JsonProperty("tank_driving")]
        public bool TankDriving { get; set; }

        [JsonProperty("terrain_friction_modifier")]
        public float TerrainFrictionModifier { get; set; }

        [JsonProperty("turret_return_timeout")]
        public float TurretReturnTimeout { get; set; }

    }

    [JsonObject("player", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Player : EntityWithHealth
    {

        [JsonProperty("alert_when_damaged")]
        public bool AlertWhenDamaged { get; set; }

        [JsonProperty("animations")]
        public object Animations { get; set; }

        [JsonProperty("build_distance")]
        public float BuildDistance { get; set; }

        [JsonProperty("crafting_categories")]
        public object CraftingCategories { get; set; }

        [JsonProperty("damage_hit_tint")]
        public object DamageHitTint { get; set; }

        [JsonProperty("distance_per_frame")]
        public float DistancePerFrame { get; set; }

        [JsonProperty("drop_item_distance")]
        public float DropItemDistance { get; set; }

        [JsonProperty("eat")]
        public object Eat { get; set; }

        [JsonProperty("healing_per_tick")]
        public float HealingPerTick { get; set; }

        [JsonProperty("heartbeat")]
        public object Heartbeat { get; set; }

        [JsonProperty("inventory_size")]
        public float InventorySize { get; set; }

        [JsonProperty("item_pickup_distance")]
        public float ItemPickupDistance { get; set; }

        [JsonProperty("light")]
        public object Light { get; set; }

        [JsonProperty("loot_pickup_distance")]
        public float LootPickupDistance { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("maximum_corner_sliding_distance")]
        public float MaximumCornerSlidingDistance { get; set; }

        [JsonProperty("mining_categories")]
        public object MiningCategories { get; set; }

        [JsonProperty("mining_speed")]
        public float MiningSpeed { get; set; }

        [JsonProperty("mining_with_hands_particles_animation_positions")]
        public object MiningWithHandsParticlesAnimationPositions { get; set; }

        [JsonProperty("mining_with_tool_particles_animation_positions")]
        public object MiningWithToolParticlesAnimationPositions { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("reach_distance")]
        public float ReachDistance { get; set; }

        [JsonProperty("reach_resource_distance")]
        public float ReachResourceDistance { get; set; }

        [JsonProperty("running_sound_animation_positions")]
        public object RunningSoundAnimationPositions { get; set; }

        [JsonProperty("running_speed")]
        public float RunningSpeed { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("ticks_to_keep_aiming_direction")]
        public float TicksToKeepAimingDirection { get; set; }

        [JsonProperty("ticks_to_keep_gun")]
        public float TicksToKeepGun { get; set; }

    }

    [JsonObject("container", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Container : EntityWithHealth
    {

        [JsonProperty("enable_inventory_bar")]
        public bool EnableInventoryBar { get; set; }

        [JsonProperty("inventory_size")]
        public float InventorySize { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("picture")]
        public object Picture { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("close_sound")]
        public object CloseSound { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("open_sound")]
        public object OpenSound { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

    }

    [JsonObject("smart-container", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SmartContainer : Container
    {

    }

    [JsonObject("logistic-container", MemberSerialization = MemberSerialization.OptIn)]
    public partial class LogisticContainer : SmartContainer
    {

        [JsonProperty("logistic_mode")]
        public string LogisticMode { get; set; }

    }

    [JsonObject("electric-pole", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ElectricPole : EntityWithHealth
    {

        [JsonProperty("connection_points")]
        public object ConnectionPoints { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("maximum_wire_distance")]
        public float MaximumWireDistance { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("radius_visualisation_picture")]
        public object RadiusVisualisationPicture { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("supply_area_distance")]
        public float SupplyAreaDistance { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("copper_wire_picture")]
        public object CopperWirePicture { get; set; }

        [JsonProperty("green_wire_picture")]
        public object GreenWirePicture { get; set; }

        [JsonProperty("red_wire_picture")]
        public object RedWirePicture { get; set; }

        [JsonProperty("wire_shadow_picture")]
        public object WireShadowPicture { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("fish", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Fish : EntityWithHealth
    {

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("furnace", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Furnace : EntityWithHealth
    {

        [JsonProperty("allowed_effects")]
        public object AllowedEffects { get; set; }

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("crafting_categories")]
        public object CraftingCategories { get; set; }

        [JsonProperty("crafting_speed")]
        public float CraftingSpeed { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string EnergyUsage { get; set; }

        [JsonProperty("light")]
        public object Light { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("module_specification")]
        public object ModuleSpecification { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("result_inventory_size")]
        public float ResultInventorySize { get; set; }

        [JsonProperty("source_inventory_size")]
        public float SourceInventorySize { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

        [JsonProperty("working_visualisations")]
        public object WorkingVisualisations { get; set; }

        [JsonProperty("close_sound")]
        public object CloseSound { get; set; }

        [JsonProperty("mined_sound")]
        public object MinedSound { get; set; }

        [JsonProperty("open_sound")]
        public object OpenSound { get; set; }

        [JsonProperty("repair_sound")]
        public object RepairSound { get; set; }

        [JsonProperty("fluid_boxes")]
        public object FluidBoxes { get; set; }

    }

    [JsonObject("inserter", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Inserter : EntityWithHealth
    {

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("energy_per_movement")]
        public float EnergyPerMovement { get; set; }

        [JsonProperty("energy_per_rotation")]
        public float EnergyPerRotation { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("extension_speed")]
        public float ExtensionSpeed { get; set; }

        [JsonProperty("hand_base_picture")]
        public object HandBasePicture { get; set; }

        [JsonProperty("hand_base_shadow")]
        public object HandBaseShadow { get; set; }

        [JsonProperty("hand_closed_picture")]
        public object HandClosedPicture { get; set; }

        [JsonProperty("hand_closed_shadow")]
        public object HandClosedShadow { get; set; }

        [JsonProperty("hand_open_picture")]
        public object HandOpenPicture { get; set; }

        [JsonProperty("hand_open_shadow")]
        public object HandOpenShadow { get; set; }

        [JsonProperty("hand_size")]
        public float HandSize { get; set; }

        [JsonProperty("insert_position")]
        public object InsertPosition { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("pickup_position")]
        public object PickupPosition { get; set; }

        [JsonProperty("platform_picture")]
        public object PlatformPicture { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("rotation_speed")]
        public float RotationSpeed { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

        [JsonProperty("filter_count")]
        public float FilterCount { get; set; }

        [JsonProperty("stack")]
        public bool Stack { get; set; }

    }

    [JsonObject("lab", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Lab : EntityWithHealth
    {

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string EnergyUsage { get; set; }

        [JsonProperty("inputs")]
        public object Inputs { get; set; }

        [JsonProperty("light")]
        public object Light { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("module_specification")]
        public object ModuleSpecification { get; set; }

        [JsonProperty("off_animation")]
        public object OffAnimation { get; set; }

        [JsonProperty("on_animation")]
        public object OnAnimation { get; set; }

        [JsonProperty("researching_speed")]
        public float ResearchingSpeed { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("lamp", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Lamp : EntityWithHealth
    {

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage_per_tick")]
        public string EnergyUsagePerTick { get; set; }

        [JsonProperty("glow_color_intensity")]
        public float GlowColorIntensity { get; set; }

        [JsonProperty("glow_size")]
        public float GlowSize { get; set; }

        [JsonProperty("light")]
        public object Light { get; set; }

        [JsonProperty("light_when_colored")]
        public object LightWhenColored { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("picture_off")]
        public object PictureOff { get; set; }

        [JsonProperty("picture_on")]
        public object PictureOn { get; set; }

        [JsonProperty("signal_to_color_mapping")]
        public object SignalToColorMapping { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("market", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Market : EntityWithHealth
    {

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("picture")]
        public object Picture { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("mining-drill", MemberSerialization = MemberSerialization.OptIn)]
    public partial class MiningDrill : EntityWithHealth
    {

        [JsonProperty("animations")]
        public object Animations { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string EnergyUsage { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("mining_power")]
        public float MiningPower { get; set; }

        [JsonProperty("mining_speed")]
        public float MiningSpeed { get; set; }

        [JsonProperty("module_specification")]
        public object ModuleSpecification { get; set; }

        [JsonProperty("radius_visualisation_picture")]
        public object RadiusVisualisationPicture { get; set; }

        [JsonProperty("resource_categories")]
        public object ResourceCategories { get; set; }

        [JsonProperty("resource_searching_radius")]
        public float ResourceSearchingRadius { get; set; }

        [JsonProperty("storage_slots")]
        public float StorageSlots { get; set; }

        [JsonProperty("vector_to_place_result")]
        public object VectorToPlaceResult { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

        [JsonProperty("base_picture")]
        public object BasePicture { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("fluid_box")]
        public object FluidBox { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("Prototype/PipeConnectable", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PipeConnectable : EntityWithHealth
    {

    }

    [JsonObject("boiler", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Boiler : PipeConnectable
    {

        [JsonProperty("burner")]
        public object Burner { get; set; }

        [JsonProperty("burning_cooldown")]
        public float BurningCooldown { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("energy_consumption")]
        public string EnergyConsumption { get; set; }

        [JsonProperty("fire")]
        public object Fire { get; set; }

        [JsonProperty("fluid_box")]
        public object FluidBox { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("structure")]
        public object Structure { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("generator", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Generator : PipeConnectable
    {

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("effectivity")]
        public float Effectivity { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("fluid_box")]
        public object FluidBox { get; set; }

        [JsonProperty("fluid_usage_per_tick")]
        public float FluidUsagePerTick { get; set; }

        [JsonProperty("horizontal_animation")]
        public object HorizontalAnimation { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("min_perceived_performance")]
        public float MinPerceivedPerformance { get; set; }

        [JsonProperty("performance_to_sound_speedup")]
        public float PerformanceToSoundSpeedup { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("smoke")]
        public object Smoke { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("vertical_animation")]
        public object VerticalAnimation { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("pump", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Pump : PipeConnectable
    {

        [JsonProperty("animations")]
        public object Animations { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string EnergyUsage { get; set; }

        [JsonProperty("fluid_box")]
        public object FluidBox { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("pumping_speed")]
        public float PumpingSpeed { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("pipe", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Pipe : PipeConnectable
    {

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("fluid_box")]
        public object FluidBox { get; set; }

        [JsonProperty("horizontal_window_bounding_box")]
        public object HorizontalWindowBoundingBox { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("vertical_window_bounding_box")]
        public object VerticalWindowBoundingBox { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("pipe-to-ground", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PipeToGround : PipeConnectable
    {

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("fluid_box")]
        public object FluidBox { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("underground_sprite")]
        public object UndergroundSprite { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("player-port", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlayerPort : EntityWithHealth
    {

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

    }

    [JsonObject("radar", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Radar : EntityWithHealth
    {

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("energy_per_nearby_scan")]
        public string EnergyPerNearbyScan { get; set; }

        [JsonProperty("energy_per_sector")]
        public string EnergyPerSector { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string EnergyUsage { get; set; }

        [JsonProperty("max_distance_of_nearby_sector_revealed")]
        public float MaxDistanceOfNearbySectorRevealed { get; set; }

        [JsonProperty("max_distance_of_sector_revealed")]
        public float MaxDistanceOfSectorRevealed { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("rail", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Rail : EntityWithHealth
    {

    }

    [JsonObject("rail-signal", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RailSignal : EntityWithHealth
    {

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("default_green_output_signal")]
        public string DefaultGreenOutputSignal { get; set; }

        [JsonProperty("default_orange_output_signal")]
        public string DefaultOrangeOutputSignal { get; set; }

        [JsonProperty("default_red_output_signal")]
        public string DefaultRedOutputSignal { get; set; }

        [JsonProperty("green_light")]
        public object GreenLight { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("orange_light")]
        public object OrangeLight { get; set; }

        [JsonProperty("red_light")]
        public object RedLight { get; set; }

    }

    [JsonObject("roboport", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Roboport : EntityWithHealth
    {

        [JsonProperty("base")]
        public object Base { get; set; }

        [JsonProperty("base_animation")]
        public object BaseAnimation { get; set; }

        [JsonProperty("base_patch")]
        public object BasePatch { get; set; }

        [JsonProperty("charge_approach_distance")]
        public float ChargeApproachDistance { get; set; }

        [JsonProperty("charging_energy")]
        public string ChargingEnergy { get; set; }

        [JsonProperty("construction_radius")]
        public float ConstructionRadius { get; set; }

        [JsonProperty("construction_radius_visualisation_picture")]
        public object ConstructionRadiusVisualisationPicture { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("door_animation_down")]
        public object DoorAnimationDown { get; set; }

        [JsonProperty("door_animation_up")]
        public object DoorAnimationUp { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string EnergyUsage { get; set; }

        [JsonProperty("logistics_radius")]
        public float LogisticsRadius { get; set; }

        [JsonProperty("material_slots_count")]
        public float MaterialSlotsCount { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("radius_visualisation_picture")]
        public object RadiusVisualisationPicture { get; set; }

        [JsonProperty("recharge_minimum")]
        public string RechargeMinimum { get; set; }

        [JsonProperty("recharging_animation")]
        public object RechargingAnimation { get; set; }

        [JsonProperty("recharging_light")]
        public object RechargingLight { get; set; }

        [JsonProperty("request_to_open_door_timeout")]
        public float RequestToOpenDoorTimeout { get; set; }

        [JsonProperty("robot_slots_count")]
        public float RobotSlotsCount { get; set; }

        [JsonProperty("spawn_and_station_height")]
        public float SpawnAndStationHeight { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("close_door_trigger_effect")]
        public object CloseDoorTriggerEffect { get; set; }

        [JsonProperty("default_available_construction_output_signal")]
        public string DefaultAvailableConstructionOutputSignal { get; set; }

        [JsonProperty("default_available_logistic_output_signal")]
        public string DefaultAvailableLogisticOutputSignal { get; set; }

        [JsonProperty("default_total_construction_output_signal")]
        public string DefaultTotalConstructionOutputSignal { get; set; }

        [JsonProperty("default_total_logistic_output_signal")]
        public string DefaultTotalLogisticOutputSignal { get; set; }

        [JsonProperty("open_door_trigger_effect")]
        public object OpenDoorTriggerEffect { get; set; }

        [JsonProperty("stationing_offset")]
        public object StationingOffset { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

        [JsonProperty("charging_offsets")]
        public object ChargingOffsets { get; set; }

        [JsonProperty("draw_construction_radius_visualization")]
        public bool DrawConstructionRadiusVisualization { get; set; }

        [JsonProperty("draw_logistic_radius_visualization")]
        public bool DrawLogisticRadiusVisualization { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("Prototype/Robot", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Robot : EntityWithHealth
    {

    }

    [JsonObject("combat-robot", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CombatRobot : Robot
    {

        [JsonProperty("alert_when_damaged")]
        public bool AlertWhenDamaged { get; set; }

        [JsonProperty("attack_parameters")]
        public object AttackParameters { get; set; }

        [JsonProperty("destroy_action")]
        public object DestroyAction { get; set; }

        [JsonProperty("distance_per_frame")]
        public float DistancePerFrame { get; set; }

        [JsonProperty("follows_player")]
        public bool FollowsPlayer { get; set; }

        [JsonProperty("friction")]
        public float Friction { get; set; }

        [JsonProperty("idle")]
        public object Idle { get; set; }

        [JsonProperty("in_motion")]
        public object InMotion { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("range_from_player")]
        public float RangeFromPlayer { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("shadow_idle")]
        public object ShadowIdle { get; set; }

        [JsonProperty("shadow_in_motion")]
        public object ShadowInMotion { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("time_to_live")]
        public float TimeToLive { get; set; }

    }

    [JsonObject("construction-robot", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConstructionRobot : Robot
    {

        [JsonProperty("cargo_centered")]
        public object CargoCentered { get; set; }

        [JsonProperty("construction_vector")]
        public object ConstructionVector { get; set; }

        [JsonProperty("energy_per_move")]
        public string EnergyPerMove { get; set; }

        [JsonProperty("energy_per_tick")]
        public string EnergyPerTick { get; set; }

        [JsonProperty("idle")]
        public object Idle { get; set; }

        [JsonProperty("in_motion")]
        public object InMotion { get; set; }

        [JsonProperty("max_energy")]
        public string MaxEnergy { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("max_payload_size")]
        public float MaxPayloadSize { get; set; }

        [JsonProperty("max_to_charge")]
        public float MaxToCharge { get; set; }

        [JsonProperty("min_to_charge")]
        public float MinToCharge { get; set; }

        [JsonProperty("repair_pack")]
        public string RepairPack { get; set; }

        [JsonProperty("shadow_idle")]
        public object ShadowIdle { get; set; }

        [JsonProperty("shadow_in_motion")]
        public object ShadowInMotion { get; set; }

        [JsonProperty("shadow_working")]
        public object ShadowWorking { get; set; }

        [JsonProperty("smoke")]
        public object Smoke { get; set; }

        [JsonProperty("sparks")]
        public object Sparks { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("speed_multiplier_when_out_of_energy")]
        public float SpeedMultiplierWhenOutOfEnergy { get; set; }

        [JsonProperty("transfer_distance")]
        public float TransferDistance { get; set; }

        [JsonProperty("working")]
        public object Working { get; set; }

        [JsonProperty("working_light")]
        public object WorkingLight { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

    }

    [JsonObject("logistic-robot", MemberSerialization = MemberSerialization.OptIn)]
    public partial class LogisticRobot : Robot
    {

        [JsonProperty("cargo_centered")]
        public object CargoCentered { get; set; }

        [JsonProperty("energy_per_move")]
        public string EnergyPerMove { get; set; }

        [JsonProperty("energy_per_tick")]
        public string EnergyPerTick { get; set; }

        [JsonProperty("idle")]
        public object Idle { get; set; }

        [JsonProperty("idle_with_cargo")]
        public object IdleWithCargo { get; set; }

        [JsonProperty("in_motion")]
        public object InMotion { get; set; }

        [JsonProperty("in_motion_with_cargo")]
        public object InMotionWithCargo { get; set; }

        [JsonProperty("max_energy")]
        public string MaxEnergy { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("max_payload_size")]
        public float MaxPayloadSize { get; set; }

        [JsonProperty("max_to_charge")]
        public float MaxToCharge { get; set; }

        [JsonProperty("min_to_charge")]
        public float MinToCharge { get; set; }

        [JsonProperty("shadow_idle")]
        public object ShadowIdle { get; set; }

        [JsonProperty("shadow_idle_with_cargo")]
        public object ShadowIdleWithCargo { get; set; }

        [JsonProperty("shadow_in_motion")]
        public object ShadowInMotion { get; set; }

        [JsonProperty("shadow_in_motion_with_cargo")]
        public object ShadowInMotionWithCargo { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("speed_multiplier_when_out_of_energy")]
        public float SpeedMultiplierWhenOutOfEnergy { get; set; }

        [JsonProperty("transfer_distance")]
        public float TransferDistance { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

    }

    [JsonObject("rocket-defense", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RocketDefense : EntityWithHealth
    {

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

    }

    [JsonObject("solar-panel", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SolarPanel : EntityWithHealth
    {

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("picture")]
        public object Picture { get; set; }

        [JsonProperty("production")]
        public string Production { get; set; }

    }

    [JsonObject("splitter", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Splitter : EntityWithHealth
    {

        [JsonProperty("animation_speed_coefficient")]
        public float AnimationSpeedCoefficient { get; set; }

        [JsonProperty("belt_horizontal")]
        public object BeltHorizontal { get; set; }

        [JsonProperty("belt_vertical")]
        public object BeltVertical { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("ending_bottom")]
        public object EndingBottom { get; set; }

        [JsonProperty("ending_patch")]
        public object EndingPatch { get; set; }

        [JsonProperty("ending_side")]
        public object EndingSide { get; set; }

        [JsonProperty("ending_top")]
        public object EndingTop { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("starting_bottom")]
        public object StartingBottom { get; set; }

        [JsonProperty("starting_side")]
        public object StartingSide { get; set; }

        [JsonProperty("starting_top")]
        public object StartingTop { get; set; }

        [JsonProperty("structure")]
        public object Structure { get; set; }

        [JsonProperty("structure_animation_movement_cooldown")]
        public float StructureAnimationMovementCooldown { get; set; }

        [JsonProperty("structure_animation_speed_coefficient")]
        public float StructureAnimationSpeedCoefficient { get; set; }

    }

    [JsonObject("train-stop", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TrainStop : EntityWithHealth
    {

        [JsonProperty("animation_ticks_per_frame")]
        public float AnimationTicksPerFrame { get; set; }

        [JsonProperty("animations")]
        public object Animations { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("drawing_boxes")]
        public object DrawingBoxes { get; set; }

        [JsonProperty("light1")]
        public object Light1 { get; set; }

        [JsonProperty("light2")]
        public object Light2 { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("rail_overlay_animations")]
        public object RailOverlayAnimations { get; set; }

        [JsonProperty("top_animations")]
        public object TopAnimations { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("Prototype/TrainUnit", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TrainUnit : EntityWithHealth
    {

    }

    [JsonObject("cargo-wagon", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CargoWagon : TrainUnit
    {

        [JsonProperty("air_resistance")]
        public float AirResistance { get; set; }

        [JsonProperty("back_light")]
        public object BackLight { get; set; }

        [JsonProperty("braking_force")]
        public float BrakingForce { get; set; }

        [JsonProperty("close_sound")]
        public object CloseSound { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("connection_distance")]
        public float ConnectionDistance { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("crash_trigger")]
        public object CrashTrigger { get; set; }

        [JsonProperty("drive_over_tie_trigger")]
        public object DriveOverTieTrigger { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("energy_per_hit_point")]
        public float EnergyPerHitPoint { get; set; }

        [JsonProperty("friction_force")]
        public float FrictionForce { get; set; }

        [JsonProperty("horizontal_doors")]
        public object HorizontalDoors { get; set; }

        [JsonProperty("inventory_size")]
        public float InventorySize { get; set; }

        [JsonProperty("joint_distance")]
        public float JointDistance { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("max_speed")]
        public float MaxSpeed { get; set; }

        [JsonProperty("mined_sound")]
        public object MinedSound { get; set; }

        [JsonProperty("open_sound")]
        public object OpenSound { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("rail_category")]
        public string RailCategory { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("sound_minimum_speed")]
        public float SoundMinimumSpeed { get; set; }

        [JsonProperty("stand_by_light")]
        public object StandByLight { get; set; }

        [JsonProperty("tie_distance")]
        public float TieDistance { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("vertical_doors")]
        public object VerticalDoors { get; set; }

        [JsonProperty("wheels")]
        public object Wheels { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("locomotive", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Locomotive : TrainUnit
    {

        [JsonProperty("air_resistance")]
        public float AirResistance { get; set; }

        [JsonProperty("back_light")]
        public object BackLight { get; set; }

        [JsonProperty("braking_force")]
        public float BrakingForce { get; set; }

        [JsonProperty("close_sound")]
        public object CloseSound { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("connection_distance")]
        public float ConnectionDistance { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("crash_trigger")]
        public object CrashTrigger { get; set; }

        [JsonProperty("drive_over_tie_trigger")]
        public object DriveOverTieTrigger { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("energy_per_hit_point")]
        public float EnergyPerHitPoint { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("friction_force")]
        public float FrictionForce { get; set; }

        [JsonProperty("front_light")]
        public object FrontLight { get; set; }

        [JsonProperty("joint_distance")]
        public float JointDistance { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("max_power")]
        public string MaxPower { get; set; }

        [JsonProperty("max_speed")]
        public float MaxSpeed { get; set; }

        [JsonProperty("mined_sound")]
        public object MinedSound { get; set; }

        [JsonProperty("open_sound")]
        public object OpenSound { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("rail_category")]
        public string RailCategory { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("reversing_power_modifier")]
        public float ReversingPowerModifier { get; set; }

        [JsonProperty("sound_minimum_speed")]
        public float SoundMinimumSpeed { get; set; }

        [JsonProperty("stand_by_light")]
        public object StandByLight { get; set; }

        [JsonProperty("stop_trigger")]
        public object StopTrigger { get; set; }

        [JsonProperty("tie_distance")]
        public float TieDistance { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("wheels")]
        public object Wheels { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("transport-belt", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TransportBelt : EntityWithHealth
    {

        [JsonProperty("animation_speed_coefficient")]
        public float AnimationSpeedCoefficient { get; set; }

        [JsonProperty("animations")]
        public object Animations { get; set; }

        [JsonProperty("belt_horizontal")]
        public object BeltHorizontal { get; set; }

        [JsonProperty("belt_vertical")]
        public object BeltVertical { get; set; }

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("connector_frame_sprites")]
        public object ConnectorFrameSprites { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("ending_bottom")]
        public object EndingBottom { get; set; }

        [JsonProperty("ending_patch")]
        public object EndingPatch { get; set; }

        [JsonProperty("ending_side")]
        public object EndingSide { get; set; }

        [JsonProperty("ending_top")]
        public object EndingTop { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("starting_bottom")]
        public object StartingBottom { get; set; }

        [JsonProperty("starting_side")]
        public object StartingSide { get; set; }

        [JsonProperty("starting_top")]
        public object StartingTop { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("transport-belt-to-ground", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TransportBeltToGround : EntityWithHealth
    {

    }

    [JsonObject("tree", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Tree : EntityWithHealth
    {

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("colors")]
        public object Colors { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("darkness_of_burnt_tree")]
        public float DarknessOfBurntTree { get; set; }

        [JsonProperty("remains_when_mined")]
        public string RemainsWhenMined { get; set; }

        [JsonProperty("variations")]
        public object Variations { get; set; }

    }

    [JsonObject("turret", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Turret : EntityWithHealth
    {

        [JsonProperty("attack_parameters")]
        public object AttackParameters { get; set; }

        [JsonProperty("build_base_evolution_requirement")]
        public float BuildBaseEvolutionRequirement { get; set; }

        [JsonProperty("call_for_help_radius")]
        public float CallForHelpRadius { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("dying_sound")]
        public object DyingSound { get; set; }

        [JsonProperty("ending_attack_animation")]
        public object EndingAttackAnimation { get; set; }

        [JsonProperty("ending_attack_speed")]
        public float EndingAttackSpeed { get; set; }

        [JsonProperty("folded_animation")]
        public object FoldedAnimation { get; set; }

        [JsonProperty("folded_speed")]
        public float FoldedSpeed { get; set; }

        [JsonProperty("folding_animation")]
        public object FoldingAnimation { get; set; }

        [JsonProperty("folding_speed")]
        public float FoldingSpeed { get; set; }

        [JsonProperty("healing_per_tick")]
        public float HealingPerTick { get; set; }

        [JsonProperty("inventory_size")]
        public float InventorySize { get; set; }

        [JsonProperty("loot")]
        public object Loot { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("prepare_range")]
        public float PrepareRange { get; set; }

        [JsonProperty("prepared_animation")]
        public object PreparedAnimation { get; set; }

        [JsonProperty("prepared_speed")]
        public float PreparedSpeed { get; set; }

        [JsonProperty("preparing_animation")]
        public object PreparingAnimation { get; set; }

        [JsonProperty("preparing_speed")]
        public float PreparingSpeed { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("rotation_speed")]
        public float RotationSpeed { get; set; }

        [JsonProperty("shooting_cursor_size")]
        public float ShootingCursorSize { get; set; }

        [JsonProperty("starting_attack_animation")]
        public object StartingAttackAnimation { get; set; }

        [JsonProperty("starting_attack_sound")]
        public object StartingAttackSound { get; set; }

        [JsonProperty("starting_attack_speed")]
        public float StartingAttackSpeed { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("ammo-turret", MemberSerialization = MemberSerialization.OptIn)]
    public partial class AmmoTurret : Turret
    {

        [JsonProperty("attacking_animation")]
        public object AttackingAnimation { get; set; }

        [JsonProperty("attacking_speed")]
        public float AttackingSpeed { get; set; }

        [JsonProperty("automated_ammo_count")]
        public float AutomatedAmmoCount { get; set; }

        [JsonProperty("base_picture")]
        public object BasePicture { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("electric-turret", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ElectricTurret : Turret
    {

        [JsonProperty("base_picture")]
        public object BasePicture { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("unit", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Unit : EntityWithHealth
    {

        [JsonProperty("attack_parameters")]
        public object AttackParameters { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("distance_per_frame")]
        public float DistancePerFrame { get; set; }

        [JsonProperty("distraction_cooldown")]
        public float DistractionCooldown { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("dying_sound")]
        public object DyingSound { get; set; }

        [JsonProperty("healing_per_tick")]
        public float HealingPerTick { get; set; }

        [JsonProperty("loot")]
        public object Loot { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("movement_speed")]
        public float MovementSpeed { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("pollution_to_join_attack")]
        public float PollutionToJoinAttack { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("run_animation")]
        public object RunAnimation { get; set; }

        [JsonProperty("spawning_time_modifier")]
        public float SpawningTimeModifier { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("vision_distance")]
        public float VisionDistance { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("unit-spawner", MemberSerialization = MemberSerialization.OptIn)]
    public partial class UnitSpawner : EntityWithHealth
    {

        [JsonProperty("animations")]
        public object Animations { get; set; }

        [JsonProperty("call_for_help_radius")]
        public float CallForHelpRadius { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("dying_sound")]
        public object DyingSound { get; set; }

        [JsonProperty("healing_per_tick")]
        public float HealingPerTick { get; set; }

        [JsonProperty("loot")]
        public object Loot { get; set; }

        [JsonProperty("max_count_of_owned_units")]
        public float MaxCountOfOwnedUnits { get; set; }

        [JsonProperty("max_friends_around_to_spawn")]
        public float MaxFriendsAroundToSpawn { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("max_richness_for_spawn_shift")]
        public float MaxRichnessForSpawnShift { get; set; }

        [JsonProperty("max_spawn_shift")]
        public float MaxSpawnShift { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("pollution_absorbtion_absolute")]
        public float PollutionAbsorbtionAbsolute { get; set; }

        [JsonProperty("pollution_absorbtion_proportional")]
        public float PollutionAbsorbtionProportional { get; set; }

        [JsonProperty("pollution_to_enhance_spawning")]
        public float PollutionToEnhanceSpawning { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("result_units")]
        public object ResultUnits { get; set; }

        [JsonProperty("spawning_cooldown")]
        public object SpawningCooldown { get; set; }

        [JsonProperty("spawning_radius")]
        public float SpawningRadius { get; set; }

        [JsonProperty("spawning_spacing")]
        public float SpawningSpacing { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("wall", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Wall : EntityWithHealth
    {

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_point")]
        public object CircuitWireConnectionPoint { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("connected_gate_visualization")]
        public object ConnectedGateVisualization { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("default_output_signal")]
        public string DefaultOutputSignal { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("mined_sound")]
        public object MinedSound { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("repair_sound")]
        public object RepairSound { get; set; }

        [JsonProperty("repair_speed_modifier")]
        public float RepairSpeedModifier { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("wall_diode_green")]
        public object WallDiodeGreen { get; set; }

        [JsonProperty("wall_diode_green_light")]
        public object WallDiodeGreenLight { get; set; }

        [JsonProperty("wall_diode_red")]
        public object WallDiodeRed { get; set; }

        [JsonProperty("wall_diode_red_light")]
        public object WallDiodeRedLight { get; set; }

    }

    [JsonObject("flying-text", MemberSerialization = MemberSerialization.OptIn)]
    public partial class FlyingText : Entity
    {

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("time_to_live")]
        public float TimeToLive { get; set; }

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
        public object Action { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("picture_safe")]
        public object PictureSafe { get; set; }

        [JsonProperty("picture_set")]
        public object PictureSet { get; set; }

        [JsonProperty("trigger_radius")]
        public float TriggerRadius { get; set; }

    }

    [JsonObject("particle", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Particle : Entity
    {

        [JsonProperty("life_time")]
        public float LifeTime { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("shadows")]
        public object Shadows { get; set; }

        [JsonProperty("movement_modifier_when_on_ground")]
        public float MovementModifierWhenOnGround { get; set; }

        [JsonProperty("ended_in_water_trigger_effect")]
        public object EndedInWaterTriggerEffect { get; set; }

        [JsonProperty("regular_trigger_effect")]
        public object RegularTriggerEffect { get; set; }

        [JsonProperty("regular_trigger_effect_frequency")]
        public float RegularTriggerEffectFrequency { get; set; }

    }

    [JsonObject("projectile", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Projectile : Entity
    {

        [JsonProperty("acceleration")]
        public float Acceleration { get; set; }

        [JsonProperty("action")]
        public object Action { get; set; }

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("rotatable")]
        public bool Rotatable { get; set; }

        [JsonProperty("shadow")]
        public object Shadow { get; set; }

        [JsonProperty("light")]
        public object Light { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("direction_only")]
        public bool DirectionOnly { get; set; }

        [JsonProperty("final_action")]
        public object FinalAction { get; set; }

        [JsonProperty("piercing_damage")]
        public float PiercingDamage { get; set; }

        [JsonProperty("smoke")]
        public object Smoke { get; set; }

    }

    [JsonObject("rail-remnants", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RailRemnants : Entity
    {

        [JsonProperty("bending_type")]
        public string BendingType { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("selectable_in_game")]
        public bool SelectableInGame { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("time_before_removed")]
        public float TimeBeforeRemoved { get; set; }

        [JsonProperty("time_before_shading_off")]
        public float TimeBeforeShadingOff { get; set; }

    }

    [JsonObject("resource", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Resource : Entity
    {

        [JsonProperty("map_color")]
        public object MapColor { get; set; }

        [JsonProperty("minimum")]
        public float Minimum { get; set; }

        [JsonProperty("normal")]
        public float Normal { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("stage_counts")]
        public object StageCounts { get; set; }

        [JsonProperty("stages")]
        public object Stages { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("infinite")]
        public bool Infinite { get; set; }

        [JsonProperty("map_grid")]
        public bool MapGrid { get; set; }

    }

    [JsonObject("smoke", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Smoke : Entity
    {

        [JsonProperty("affected_by_wind")]
        public bool AffectedByWind { get; set; }

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("cyclic")]
        public bool Cyclic { get; set; }

        [JsonProperty("duration")]
        public float Duration { get; set; }

        [JsonProperty("end_scale")]
        public float EndScale { get; set; }

        [JsonProperty("fade_away_duration")]
        public float FadeAwayDuration { get; set; }

        [JsonProperty("spread_duration")]
        public float SpreadDuration { get; set; }

        [JsonProperty("start_scale")]
        public float StartScale { get; set; }

        [JsonProperty("fade_in_duration")]
        public float FadeInDuration { get; set; }

        [JsonProperty("glow_animation")]
        public object GlowAnimation { get; set; }

        [JsonProperty("glow_fade_away_duration")]
        public float GlowFadeAwayDuration { get; set; }

        [JsonProperty("movement_slow_down_factor")]
        public float MovementSlowDownFactor { get; set; }

        [JsonProperty("render_layer")]
        public string RenderLayer { get; set; }

        [JsonProperty("show_when_smoke_off")]
        public bool ShowWhenSmokeOff { get; set; }

    }

    [JsonObject("sticker", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Sticker : Entity
    {

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("damage_per_tick")]
        public object DamagePerTick { get; set; }

        [JsonProperty("duration_in_ticks")]
        public float DurationInTicks { get; set; }

        [JsonProperty("fire_spread_cooldown")]
        public float FireSpreadCooldown { get; set; }

        [JsonProperty("fire_spread_radius")]
        public float FireSpreadRadius { get; set; }

        [JsonProperty("spread_fire_entity")]
        public string SpreadFireEntity { get; set; }

        [JsonProperty("target_movement_modifier")]
        public float TargetMovementModifier { get; set; }

    }

    public partial class Item
    {

        [JsonProperty("default_request_amount")]
        public float DefaultRequestAmount { get; set; }

        [JsonProperty("placed_as_equipment_result")]
        public string PlacedAsEquipmentResult { get; set; }

        [JsonProperty("dark_background_icon")]
        public string DarkBackgroundIcon { get; set; }

        [JsonProperty("place_as_tile")]
        public object PlaceAsTile { get; set; }

        [JsonProperty("damage_radius")]
        public float DamageRadius { get; set; }

        [JsonProperty("trigger_radius")]
        public float TriggerRadius { get; set; }

    }

    [JsonObject("ammo", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Ammo : Item
    {

        [JsonProperty("ammo_type")]
        public object AmmoType { get; set; }

        [JsonProperty("magazine_size")]
        public float MagazineSize { get; set; }

    }

    [JsonObject("armor", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Armor : Item
    {

        [JsonProperty("durability")]
        public float Durability { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("equipment_grid")]
        public object EquipmentGrid { get; set; }

        [JsonProperty("inventory_size_bonus")]
        public float InventorySizeBonus { get; set; }

    }

    [JsonObject("capsule", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Capsule : Item
    {

        [JsonProperty("capsule_action")]
        public object CapsuleAction { get; set; }

    }

    [JsonObject("Prototype/Equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Equipment : Item
    {

    }

    [JsonObject("night-vision-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class NightVisionEquipment : Equipment
    {

        [JsonProperty("energy_input")]
        public string EnergyInput { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("shape")]
        public object Shape { get; set; }

        [JsonProperty("sprite")]
        public object Sprite { get; set; }

        [JsonProperty("tint")]
        public object Tint { get; set; }

    }

    [JsonObject("energy-shield-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class EnergyShieldEquipment : Equipment
    {

        [JsonProperty("energy_per_shield")]
        public string EnergyPerShield { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("max_shield_value")]
        public float MaxShieldValue { get; set; }

        [JsonProperty("shape")]
        public object Shape { get; set; }

        [JsonProperty("sprite")]
        public object Sprite { get; set; }

    }

    [JsonObject("battery-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class BatteryEquipment : Equipment
    {

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("shape")]
        public object Shape { get; set; }

        [JsonProperty("sprite")]
        public object Sprite { get; set; }

    }

    [JsonObject("solar-panel-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SolarPanelEquipment : Equipment
    {

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("shape")]
        public object Shape { get; set; }

        [JsonProperty("sprite")]
        public object Sprite { get; set; }

    }

    [JsonObject("generator-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class GeneratorEquipment : Equipment
    {

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("shape")]
        public object Shape { get; set; }

        [JsonProperty("sprite")]
        public object Sprite { get; set; }

    }

    [JsonObject("active-defense-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ActiveDefenseEquipment : Equipment
    {

        [JsonProperty("ability_icon")]
        public object AbilityIcon { get; set; }

        [JsonProperty("attack_parameters")]
        public object AttackParameters { get; set; }

        [JsonProperty("automatic")]
        public bool Automatic { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("shape")]
        public object Shape { get; set; }

        [JsonProperty("sprite")]
        public object Sprite { get; set; }

    }

    [JsonObject("movement-bonus-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class MovementBonusEquipment : Equipment
    {

        [JsonProperty("energy_consumption")]
        public string EnergyConsumption { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("movement_bonus")]
        public float MovementBonus { get; set; }

        [JsonProperty("shape")]
        public object Shape { get; set; }

        [JsonProperty("sprite")]
        public object Sprite { get; set; }

    }

    [JsonObject("gun", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Gun : Item
    {

        [JsonProperty("attack_parameters")]
        public object AttackParameters { get; set; }

    }

    [JsonObject("mining-tool", MemberSerialization = MemberSerialization.OptIn)]
    public partial class MiningTool : Item
    {

        [JsonProperty("action")]
        public object Action { get; set; }

        [JsonProperty("durability")]
        public float Durability { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

    }

    [JsonObject("module", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Module : Item
    {

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("effect")]
        public object Effect { get; set; }

        [JsonProperty("tier")]
        public float Tier { get; set; }

        [JsonProperty("limitation")]
        public object Limitation { get; set; }

        [JsonProperty("limitation_message_key")]
        public string LimitationMessageKey { get; set; }

    }

    public partial class ItemGroup
    {

        [JsonProperty("inventory_order")]
        public string InventoryOrder { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

    }

    [JsonObject("map-settings", MemberSerialization = MemberSerialization.OptIn)]
    public partial class MapSettings : TypedNamedBase
    {

        [JsonProperty("attack")]
        public object Attack { get; set; }

        [JsonProperty("enemy_evolution")]
        public object EnemyEvolution { get; set; }

        [JsonProperty("enemy_expansion")]
        public object EnemyExpansion { get; set; }

        [JsonProperty("max_failed_behavior_count")]
        public float MaxFailedBehaviorCount { get; set; }

        [JsonProperty("path_finder")]
        public object PathFinder { get; set; }

        [JsonProperty("pollution")]
        public object Pollution { get; set; }

        [JsonProperty("steering")]
        public object Steering { get; set; }

        [JsonProperty("unit_group")]
        public object UnitGroup { get; set; }

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
        public object Ingredients { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("results")]
        public object Results { get; set; }

        [JsonProperty("main_product")]
        public string MainProduct { get; set; }

        [JsonProperty("requester_paste_multiplier")]
        public float RequesterPasteMultiplier { get; set; }

        [JsonProperty("hidden")]
        public object Hidden { get; set; }

    }

    public partial class RecipeCategory
    {

    }

    public partial class Technology
    {

        [JsonProperty("unit")]
        public object Unit { get; set; }

        [JsonProperty("upgrade")]
        public object Upgrade { get; set; }

        [JsonProperty("icon_size")]
        public float IconSize { get; set; }

    }

    [JsonObject("tile", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Tile : TypedNamedBase
    {

        [JsonProperty("ageing")]
        public float Ageing { get; set; }

        [JsonProperty("collision_mask")]
        public object CollisionMask { get; set; }

        [JsonProperty("decorative_removal_probability")]
        public float DecorativeRemovalProbability { get; set; }

        [JsonProperty("layer")]
        public float Layer { get; set; }

        [JsonProperty("map_color")]
        public object MapColor { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("mined_sound")]
        public object MinedSound { get; set; }

        [JsonProperty("needs_correction")]
        public bool NeedsCorrection { get; set; }

        [JsonProperty("variants")]
        public object Variants { get; set; }

        [JsonProperty("vehicle_friction_modifier")]
        public float VehicleFrictionModifier { get; set; }

        [JsonProperty("walking_sound")]
        public object WalkingSound { get; set; }

        [JsonProperty("walking_speed_modifier")]
        public float WalkingSpeedModifier { get; set; }

        [JsonProperty("allowed_neighbors")]
        public object AllowedNeighbors { get; set; }

        [JsonProperty("autoplace")]
        public object Autoplace { get; set; }

        [JsonProperty("can_be_part_of_blueprint")]
        public bool CanBePartOfBlueprint { get; set; }

        [JsonProperty("next_direction")]
        public string NextDirection { get; set; }

    }

    [JsonObject("achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Achievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

    }

    [JsonObject("ambient-sound", MemberSerialization = MemberSerialization.OptIn)]
    public partial class AmbientSound : TypedNamedBase
    {

        [JsonProperty("sound")]
        public object Sound { get; set; }

        [JsonProperty("track_type")]
        public string TrackType { get; set; }

    }

    [JsonObject("arithmetic-combinator", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ArithmeticCombinator : TypedNamedBase
    {

        [JsonProperty("active_energy_usage")]
        public string ActiveEnergyUsage { get; set; }

        [JsonProperty("activity_led_light")]
        public object ActivityLedLight { get; set; }

        [JsonProperty("activity_led_light_offsets")]
        public object ActivityLedLightOffsets { get; set; }

        [JsonProperty("activity_led_sprites")]
        public object ActivityLedSprites { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("divide_symbol_sprites")]
        public object DivideSymbolSprites { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("input_connection_bounding_box")]
        public object InputConnectionBoundingBox { get; set; }

        [JsonProperty("input_connection_points")]
        public object InputConnectionPoints { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("minus_symbol_sprites")]
        public object MinusSymbolSprites { get; set; }

        [JsonProperty("multiply_symbol_sprites")]
        public object MultiplySymbolSprites { get; set; }

        [JsonProperty("output_connection_bounding_box")]
        public object OutputConnectionBoundingBox { get; set; }

        [JsonProperty("output_connection_points")]
        public object OutputConnectionPoints { get; set; }

        [JsonProperty("plus_symbol_sprites")]
        public object PlusSymbolSprites { get; set; }

        [JsonProperty("screen_light")]
        public object ScreenLight { get; set; }

        [JsonProperty("screen_light_offsets")]
        public object ScreenLightOffsets { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("sprites")]
        public object Sprites { get; set; }

    }

    [JsonObject("beam", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Beam : TypedNamedBase
    {

        [JsonProperty("action")]
        public object Action { get; set; }

        [JsonProperty("body")]
        public object Body { get; set; }

        [JsonProperty("damage_interval")]
        public float DamageInterval { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("head")]
        public object Head { get; set; }

        [JsonProperty("tail")]
        public object Tail { get; set; }

        [JsonProperty("width")]
        public float Width { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("blueprint", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Blueprint : TypedNamedBase
    {

        [JsonProperty("alt_selection_color")]
        public object AltSelectionColor { get; set; }

        [JsonProperty("alt_selection_cursor_box_type")]
        public string AltSelectionCursorBoxType { get; set; }

        [JsonProperty("alt_selection_mode")]
        public object AltSelectionMode { get; set; }

        [JsonProperty("draw_label_for_cursor_render")]
        public bool DrawLabelForCursorRender { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("item_to_clear")]
        public string ItemToClear { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("selection_color")]
        public object SelectionColor { get; set; }

        [JsonProperty("selection_cursor_box_type")]
        public string SelectionCursorBoxType { get; set; }

        [JsonProperty("selection_mode")]
        public object SelectionMode { get; set; }

        [JsonProperty("stack_size")]
        public float StackSize { get; set; }

        [JsonProperty("stackable")]
        public bool Stackable { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("blueprint-book", MemberSerialization = MemberSerialization.OptIn)]
    public partial class BlueprintBook : TypedNamedBase
    {

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("inventory_size")]
        public float InventorySize { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("stack_size")]
        public float StackSize { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("build-entity-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class BuildEntityAchievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("to_build")]
        public string ToBuild { get; set; }

        [JsonProperty("until_second")]
        public float UntilSecond { get; set; }

    }

    [JsonObject("combat-robot-count", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CombatRobotCount : TypedNamedBase
    {

        [JsonProperty("count")]
        public float Count { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string SteamStatsName { get; set; }

    }

    [JsonObject("constant-combinator", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConstantCombinator : TypedNamedBase
    {

        [JsonProperty("activity_led_light")]
        public object ActivityLedLight { get; set; }

        [JsonProperty("activity_led_light_offsets")]
        public object ActivityLedLightOffsets { get; set; }

        [JsonProperty("activity_led_sprites")]
        public object ActivityLedSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("item_slot_count")]
        public float ItemSlotCount { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("sprites")]
        public object Sprites { get; set; }

    }

    [JsonObject("construct-with-robots-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConstructWithRobotsAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("limited_to_one_game")]
        public bool LimitedToOneGame { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string SteamStatsName { get; set; }

        [JsonProperty("more_than_manually")]
        public bool MoreThanManually { get; set; }

    }

    [JsonObject("curved-rail", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CurvedRail : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("placeable_by")]
        public object PlaceableBy { get; set; }

        [JsonProperty("rail_category")]
        public string RailCategory { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("secondary_collision_box")]
        public object SecondaryCollisionBox { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

    }

    [JsonObject("custom-input", MemberSerialization = MemberSerialization.OptIn)]
    public partial class CustomInput : TypedNamedBase
    {

        [JsonProperty("consuming")]
        public string Consuming { get; set; }

        [JsonProperty("key_sequence")]
        public string KeySequence { get; set; }

    }

    [JsonObject("decider-combinator", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeciderCombinator : TypedNamedBase
    {

        [JsonProperty("active_energy_usage")]
        public string ActiveEnergyUsage { get; set; }

        [JsonProperty("activity_led_light")]
        public object ActivityLedLight { get; set; }

        [JsonProperty("activity_led_light_offsets")]
        public object ActivityLedLightOffsets { get; set; }

        [JsonProperty("activity_led_sprites")]
        public object ActivityLedSprites { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("equal_symbol_sprites")]
        public object EqualSymbolSprites { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("greater_symbol_sprites")]
        public object GreaterSymbolSprites { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("input_connection_bounding_box")]
        public object InputConnectionBoundingBox { get; set; }

        [JsonProperty("input_connection_points")]
        public object InputConnectionPoints { get; set; }

        [JsonProperty("less_symbol_sprites")]
        public object LessSymbolSprites { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("output_connection_bounding_box")]
        public object OutputConnectionBoundingBox { get; set; }

        [JsonProperty("output_connection_points")]
        public object OutputConnectionPoints { get; set; }

        [JsonProperty("screen_light")]
        public object ScreenLight { get; set; }

        [JsonProperty("screen_light_offsets")]
        public object ScreenLightOffsets { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("sprites")]
        public object Sprites { get; set; }

    }

    [JsonObject("deconstructible-tile-proxy", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeconstructibleTileProxy : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

    }

    [JsonObject("deconstruction-item", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeconstructionItem : TypedNamedBase
    {

        [JsonProperty("alt_selection_color")]
        public object AltSelectionColor { get; set; }

        [JsonProperty("alt_selection_cursor_box_type")]
        public string AltSelectionCursorBoxType { get; set; }

        [JsonProperty("alt_selection_mode")]
        public object AltSelectionMode { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("selection_color")]
        public object SelectionColor { get; set; }

        [JsonProperty("selection_cursor_box_type")]
        public string SelectionCursorBoxType { get; set; }

        [JsonProperty("selection_mode")]
        public object SelectionMode { get; set; }

        [JsonProperty("stack_size")]
        public float StackSize { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("deconstruct-with-robots-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeconstructWithRobotsAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string SteamStatsName { get; set; }

    }

    [JsonObject("deliver-by-robots-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeliverByRobotsAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string SteamStatsName { get; set; }

    }

    [JsonObject("dont-build-entity-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DontBuildEntityAchievement : TypedNamedBase
    {

        [JsonProperty("dont_build")]
        public object DontBuild { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("allowed_in_peaceful_mode")]
        public bool AllowedInPeacefulMode { get; set; }

    }

    [JsonObject("dont-craft-manually-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DontCraftManuallyAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

    }

    [JsonObject("dont-use-entity-in-energy-production-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DontUseEntityInEnergyProductionAchievement : TypedNamedBase
    {

        [JsonProperty("excluded")]
        public string Excluded { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("included")]
        public string Included { get; set; }

        [JsonProperty("last_hour_only")]
        public bool LastHourOnly { get; set; }

        [JsonProperty("minimum_energy_produced")]
        public string MinimumEnergyProduced { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("allowed_in_peaceful_mode")]
        public bool AllowedInPeacefulMode { get; set; }

    }

    [JsonObject("entity-ghost", MemberSerialization = MemberSerialization.OptIn)]
    public partial class EntityGhost : TypedNamedBase
    {

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

    }

    [JsonObject("finish-the-game-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class FinishTheGameAchievement : TypedNamedBase
    {

        [JsonProperty("allowed_in_peaceful_mode")]
        public bool AllowedInPeacefulMode { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("until_second")]
        public float UntilSecond { get; set; }

    }

    [JsonObject("fire", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Fire : TypedNamedBase
    {

        [JsonProperty("add_fuel_cooldown")]
        public float AddFuelCooldown { get; set; }

        [JsonProperty("burnt_patch_alpha_default")]
        public float BurntPatchAlphaDefault { get; set; }

        [JsonProperty("burnt_patch_alpha_variations")]
        public object BurntPatchAlphaVariations { get; set; }

        [JsonProperty("burnt_patch_lifetime")]
        public float BurntPatchLifetime { get; set; }

        [JsonProperty("burnt_patch_pictures")]
        public object BurntPatchPictures { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("damage_per_tick")]
        public object DamagePerTick { get; set; }

        [JsonProperty("delay_between_initial_flames")]
        public float DelayBetweenInitialFlames { get; set; }

        [JsonProperty("duration")]
        public float Duration { get; set; }

        [JsonProperty("emissions_per_tick")]
        public float EmissionsPerTick { get; set; }

        [JsonProperty("end_scale")]
        public float EndScale { get; set; }

        [JsonProperty("fade_away_duration")]
        public float FadeAwayDuration { get; set; }

        [JsonProperty("fade_in_duration")]
        public float FadeInDuration { get; set; }

        [JsonProperty("fade_out_duration")]
        public float FadeOutDuration { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("flame_alpha")]
        public float FlameAlpha { get; set; }

        [JsonProperty("flame_alpha_deviation")]
        public float FlameAlphaDeviation { get; set; }

        [JsonProperty("increase_duration_by")]
        public float IncreaseDurationBy { get; set; }

        [JsonProperty("increase_duration_cooldown")]
        public float IncreaseDurationCooldown { get; set; }

        [JsonProperty("initial_lifetime")]
        public float InitialLifetime { get; set; }

        [JsonProperty("lifetime_increase_by")]
        public float LifetimeIncreaseBy { get; set; }

        [JsonProperty("lifetime_increase_cooldown")]
        public float LifetimeIncreaseCooldown { get; set; }

        [JsonProperty("light")]
        public object Light { get; set; }

        [JsonProperty("maximum_spread_count")]
        public float MaximumSpreadCount { get; set; }

        [JsonProperty("on_fuel_added_action")]
        public object OnFuelAddedAction { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("smoke")]
        public object Smoke { get; set; }

        [JsonProperty("smoke_source_pictures")]
        public object SmokeSourcePictures { get; set; }

        [JsonProperty("spawn_entity")]
        public string SpawnEntity { get; set; }

        [JsonProperty("spread_delay")]
        public float SpreadDelay { get; set; }

        [JsonProperty("spread_delay_deviation")]
        public float SpreadDelayDeviation { get; set; }

        [JsonProperty("spread_duration")]
        public float SpreadDuration { get; set; }

        [JsonProperty("start_scale")]
        public float StartScale { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

        [JsonProperty("small_tree_fire_pictures")]
        public object SmallTreeFirePictures { get; set; }

        [JsonProperty("smoke_fade_in_duration")]
        public float SmokeFadeInDuration { get; set; }

        [JsonProperty("smoke_fade_out_duration")]
        public float SmokeFadeOutDuration { get; set; }

        [JsonProperty("tree_dying_factor")]
        public float TreeDyingFactor { get; set; }

    }

    [JsonObject("fluid", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Fluid : TypedNamedBase
    {

        [JsonProperty("base_color")]
        public object BaseColor { get; set; }

        [JsonProperty("default_temperature")]
        public float DefaultTemperature { get; set; }

        [JsonProperty("flow_color")]
        public object FlowColor { get; set; }

        [JsonProperty("flow_to_energy_ratio")]
        public float FlowToEnergyRatio { get; set; }

        [JsonProperty("heat_capacity")]
        public string HeatCapacity { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_temperature")]
        public float MaxTemperature { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("pressure_to_speed_ratio")]
        public float PressureToSpeedRatio { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("fluid-turret", MemberSerialization = MemberSerialization.OptIn)]
    public partial class FluidTurret : TypedNamedBase
    {

        [JsonProperty("activation_buffer_ratio")]
        public float ActivationBufferRatio { get; set; }

        [JsonProperty("attack_parameters")]
        public object AttackParameters { get; set; }

        [JsonProperty("attacking_animation")]
        public object AttackingAnimation { get; set; }

        [JsonProperty("attacking_animation_fade_out")]
        public float AttackingAnimationFadeOut { get; set; }

        [JsonProperty("attacking_muzzle_animation_shift")]
        public object AttackingMuzzleAnimationShift { get; set; }

        [JsonProperty("attacking_speed")]
        public float AttackingSpeed { get; set; }

        [JsonProperty("automated_ammo_count")]
        public float AutomatedAmmoCount { get; set; }

        [JsonProperty("base_picture")]
        public object BasePicture { get; set; }

        [JsonProperty("base_picture_render_layer")]
        public string BasePictureRenderLayer { get; set; }

        [JsonProperty("base_picture_secondary_draw_order")]
        public float BasePictureSecondaryDrawOrder { get; set; }

        [JsonProperty("call_for_help_radius")]
        public float CallForHelpRadius { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("ending_attack_animation")]
        public object EndingAttackAnimation { get; set; }

        [JsonProperty("ending_attack_muzzle_animation_shift")]
        public object EndingAttackMuzzleAnimationShift { get; set; }

        [JsonProperty("ending_attack_speed")]
        public float EndingAttackSpeed { get; set; }

        [JsonProperty("enough_fuel_indicator_picture")]
        public object EnoughFuelIndicatorPicture { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("fluid_box")]
        public object FluidBox { get; set; }

        [JsonProperty("fluid_buffer_input_flow")]
        public float FluidBufferInputFlow { get; set; }

        [JsonProperty("fluid_buffer_size")]
        public float FluidBufferSize { get; set; }

        [JsonProperty("folded_animation")]
        public object FoldedAnimation { get; set; }

        [JsonProperty("folded_muzzle_animation_shift")]
        public object FoldedMuzzleAnimationShift { get; set; }

        [JsonProperty("folding_animation")]
        public object FoldingAnimation { get; set; }

        [JsonProperty("folding_muzzle_animation_shift")]
        public object FoldingMuzzleAnimationShift { get; set; }

        [JsonProperty("folding_speed")]
        public float FoldingSpeed { get; set; }

        [JsonProperty("gun_animation_render_layer")]
        public string GunAnimationRenderLayer { get; set; }

        [JsonProperty("gun_animation_secondary_draw_order")]
        public float GunAnimationSecondaryDrawOrder { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("indicator_light")]
        public object IndicatorLight { get; set; }

        [JsonProperty("inventory_size")]
        public float InventorySize { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("muzzle_animation")]
        public object MuzzleAnimation { get; set; }

        [JsonProperty("muzzle_light")]
        public object MuzzleLight { get; set; }

        [JsonProperty("not_enough_fuel_indicator_picture")]
        public object NotEnoughFuelIndicatorPicture { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("prepare_range")]
        public float PrepareRange { get; set; }

        [JsonProperty("prepared_animation")]
        public object PreparedAnimation { get; set; }

        [JsonProperty("prepared_muzzle_animation_shift")]
        public object PreparedMuzzleAnimationShift { get; set; }

        [JsonProperty("preparing_animation")]
        public object PreparingAnimation { get; set; }

        [JsonProperty("preparing_muzzle_animation_shift")]
        public object PreparingMuzzleAnimationShift { get; set; }

        [JsonProperty("preparing_speed")]
        public float PreparingSpeed { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("rotation_speed")]
        public float RotationSpeed { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("shoot_in_prepare_state")]
        public bool ShootInPrepareState { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("font", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Font : TypedNamedBase
    {

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("size")]
        public float Size { get; set; }

        [JsonProperty("border")]
        public bool Border { get; set; }

        [JsonProperty("border_color")]
        public object BorderColor { get; set; }

    }

    [JsonObject("gate", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Gate : TypedNamedBase
    {

        [JsonProperty("activation_distance")]
        public float ActivationDistance { get; set; }

        [JsonProperty("close_sound")]
        public object CloseSound { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string FastReplaceableGroup { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("horizontal_animation")]
        public object HorizontalAnimation { get; set; }

        [JsonProperty("horizontal_base")]
        public object HorizontalBase { get; set; }

        [JsonProperty("horizontal_rail_animation_left")]
        public object HorizontalRailAnimationLeft { get; set; }

        [JsonProperty("horizontal_rail_animation_right")]
        public object HorizontalRailAnimationRight { get; set; }

        [JsonProperty("horizontal_rail_base")]
        public object HorizontalRailBase { get; set; }

        [JsonProperty("horizontal_rail_base_mask")]
        public object HorizontalRailBaseMask { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("open_sound")]
        public object OpenSound { get; set; }

        [JsonProperty("opening_speed")]
        public float OpeningSpeed { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("timeout_to_close")]
        public float TimeoutToClose { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("vertical_animation")]
        public object VerticalAnimation { get; set; }

        [JsonProperty("vertical_base")]
        public object VerticalBase { get; set; }

        [JsonProperty("vertical_rail_animation_left")]
        public object VerticalRailAnimationLeft { get; set; }

        [JsonProperty("vertical_rail_animation_right")]
        public object VerticalRailAnimationRight { get; set; }

        [JsonProperty("vertical_rail_base")]
        public object VerticalRailBase { get; set; }

        [JsonProperty("vertical_rail_base_mask")]
        public object VerticalRailBaseMask { get; set; }

        [JsonProperty("wall_patch")]
        public object WallPatch { get; set; }

    }

    [JsonObject("group-attack-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupAttackAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

    }

    [JsonObject("gui-style", MemberSerialization = MemberSerialization.OptIn)]
    public partial class GuiStyle : TypedNamedBase
    {

        [JsonProperty("ability_slot_style")]
        public object AbilitySlotStyle { get; set; }

        [JsonProperty("achievement_card_progressbar_style")]
        public object AchievementCardProgressbarStyle { get; set; }

        [JsonProperty("achievement_description_label_style")]
        public object AchievementDescriptionLabelStyle { get; set; }

        [JsonProperty("achievement_failed_description_label_style")]
        public object AchievementFailedDescriptionLabelStyle { get; set; }

        [JsonProperty("achievement_failed_reason_label_style")]
        public object AchievementFailedReasonLabelStyle { get; set; }

        [JsonProperty("achievement_failed_title_label_style")]
        public object AchievementFailedTitleLabelStyle { get; set; }

        [JsonProperty("achievement_locked_description_label_style")]
        public object AchievementLockedDescriptionLabelStyle { get; set; }

        [JsonProperty("achievement_locked_progress_label_style")]
        public object AchievementLockedProgressLabelStyle { get; set; }

        [JsonProperty("achievement_locked_title_label_style")]
        public object AchievementLockedTitleLabelStyle { get; set; }

        [JsonProperty("achievement_percent_label_style")]
        public object AchievementPercentLabelStyle { get; set; }

        [JsonProperty("achievement_pinned_card_progressbar_style")]
        public object AchievementPinnedCardProgressbarStyle { get; set; }

        [JsonProperty("achievement_progressbar_style")]
        public object AchievementProgressbarStyle { get; set; }

        [JsonProperty("achievement_title_label_style")]
        public object AchievementTitleLabelStyle { get; set; }

        [JsonProperty("achievement_unlocked_description_label_style")]
        public object AchievementUnlockedDescriptionLabelStyle { get; set; }

        [JsonProperty("achievement_unlocked_title_label_style")]
        public object AchievementUnlockedTitleLabelStyle { get; set; }

        [JsonProperty("achievements_flow_style")]
        public object AchievementsFlowStyle { get; set; }

        [JsonProperty("activity_bar_style")]
        public object ActivityBarStyle { get; set; }

        [JsonProperty("available_preview_technology_slot_style")]
        public object AvailablePreviewTechnologySlotStyle { get; set; }

        [JsonProperty("available_technology_slot_style")]
        public object AvailableTechnologySlotStyle { get; set; }

        [JsonProperty("battery_progressbar_style")]
        public object BatteryProgressbarStyle { get; set; }

        [JsonProperty("bob-inserter-blank")]
        public object BobInserterBlank { get; set; }

        [JsonProperty("bob-inserter-checkbox")]
        public object BobInserterCheckbox { get; set; }

        [JsonProperty("bob-inserter-checkbox-drop")]
        public object BobInserterCheckboxDrop { get; set; }

        [JsonProperty("bob-inserter-checkbox-pickup")]
        public object BobInserterCheckboxPickup { get; set; }

        [JsonProperty("bob-inserter-checkbox-small")]
        public object BobInserterCheckboxSmall { get; set; }

        [JsonProperty("bob-inserter-middle")]
        public object BobInserterMiddle { get; set; }

        [JsonProperty("bob-table")]
        public object BobTable { get; set; }

        [JsonProperty("bold_label_style")]
        public object BoldLabelStyle { get; set; }

        [JsonProperty("bonus_progressbar_style")]
        public object BonusProgressbarStyle { get; set; }

        [JsonProperty("browse_games_gui_line_style")]
        public object BrowseGamesGuiLineStyle { get; set; }

        [JsonProperty("browse_games_scroll_pane_style")]
        public object BrowseGamesScrollPaneStyle { get; set; }

        [JsonProperty("browse_games_table_style")]
        public object BrowseGamesTableStyle { get; set; }

        [JsonProperty("browse_mods_scroll_pane_style")]
        public object BrowseModsScrollPaneStyle { get; set; }

        [JsonProperty("browse_mods_table_style")]
        public object BrowseModsTableStyle { get; set; }

        [JsonProperty("burning_progressbar_style")]
        public object BurningProgressbarStyle { get; set; }

        [JsonProperty("button_style")]
        public object ButtonStyle { get; set; }

        [JsonProperty("campaign_levels_listbox_style")]
        public object CampaignLevelsListboxStyle { get; set; }

        [JsonProperty("campaigns_listbox_style")]
        public object CampaignsListboxStyle { get; set; }

        [JsonProperty("caption_label_style")]
        public object CaptionLabelStyle { get; set; }

        [JsonProperty("checkbox_style")]
        public object CheckboxStyle { get; set; }

        [JsonProperty("circuit_condition_sign_button_style")]
        public object CircuitConditionSignButtonStyle { get; set; }

        [JsonProperty("console_input_textfield_style")]
        public object ConsoleInputTextfieldStyle { get; set; }

        [JsonProperty("control_settings_table_style")]
        public object ControlSettingsTableStyle { get; set; }

        [JsonProperty("controls_settings_button_style")]
        public object ControlsSettingsButtonStyle { get; set; }

        [JsonProperty("crafting_queue_slot_style")]
        public object CraftingQueueSlotStyle { get; set; }

        [JsonProperty("cursor_box")]
        public object CursorBox { get; set; }

        [JsonProperty("custom_games_listbox_style")]
        public object CustomGamesListboxStyle { get; set; }

        [JsonProperty("description_flow_style")]
        public object DescriptionFlowStyle { get; set; }

        [JsonProperty("description_label_style")]
        public object DescriptionLabelStyle { get; set; }

        [JsonProperty("description_remark_label_style")]
        public object DescriptionRemarkLabelStyle { get; set; }

        [JsonProperty("description_title_label_style")]
        public object DescriptionTitleLabelStyle { get; set; }

        [JsonProperty("description_value_label_style")]
        public object DescriptionValueLabelStyle { get; set; }

        [JsonProperty("dialog_button_style")]
        public object DialogButtonStyle { get; set; }

        [JsonProperty("disabled_technology_slot_style")]
        public object DisabledTechnologySlotStyle { get; set; }

        [JsonProperty("dropdown_style")]
        public object DropdownStyle { get; set; }

        [JsonProperty("edit_label_button_style")]
        public object EditLabelButtonStyle { get; set; }

        [JsonProperty("electric_network_sections_table_style")]
        public object ElectricNetworkSectionsTableStyle { get; set; }

        [JsonProperty("electric_satisfaction_in_description_progressbar_style")]
        public object ElectricSatisfactionInDescriptionProgressbarStyle { get; set; }

        [JsonProperty("electric_satisfaction_progressbar_style")]
        public object ElectricSatisfactionProgressbarStyle { get; set; }

        [JsonProperty("electric_usage_label_style")]
        public object ElectricUsageLabelStyle { get; set; }

        [JsonProperty("entity_info_label_style")]
        public object EntityInfoLabelStyle { get; set; }

        [JsonProperty("failed_achievement_frame_style")]
        public object FailedAchievementFrameStyle { get; set; }

        [JsonProperty("fake_disabled_button_style")]
        public object FakeDisabledButtonStyle { get; set; }

        [JsonProperty("flip_button_style_left")]
        public object FlipButtonStyleLeft { get; set; }

        [JsonProperty("flip_button_style_right")]
        public object FlipButtonStyleRight { get; set; }

        [JsonProperty("floating_train_station_listbox_style")]
        public object FloatingTrainStationListboxStyle { get; set; }

        [JsonProperty("flow_style")]
        public object FlowStyle { get; set; }

        [JsonProperty("frame_caption_label_style")]
        public object FrameCaptionLabelStyle { get; set; }

        [JsonProperty("frame_in_right_container_style")]
        public object FrameInRightContainerStyle { get; set; }

        [JsonProperty("frame_style")]
        public object FrameStyle { get; set; }

        [JsonProperty("goal_frame_style")]
        public object GoalFrameStyle { get; set; }

        [JsonProperty("goal_label_style")]
        public object GoalLabelStyle { get; set; }

        [JsonProperty("graph_style")]
        public object GraphStyle { get; set; }

        [JsonProperty("green_circuit_network_content_slot_style")]
        public object GreenCircuitNetworkContentSlotStyle { get; set; }

        [JsonProperty("green_slot_button_style")]
        public object GreenSlotButtonStyle { get; set; }

        [JsonProperty("health_progressbar_style")]
        public object HealthProgressbarStyle { get; set; }

        [JsonProperty("horizontal_line_style")]
        public object HorizontalLineStyle { get; set; }

        [JsonProperty("image_tab_selected_slot_style")]
        public object ImageTabSelectedSlotStyle { get; set; }

        [JsonProperty("image_tab_slot_style")]
        public object ImageTabSlotStyle { get; set; }

        [JsonProperty("inner_frame_in_outer_frame_style")]
        public object InnerFrameInOuterFrameStyle { get; set; }

        [JsonProperty("inner_frame_style")]
        public object InnerFrameStyle { get; set; }

        [JsonProperty("invalid_label_style")]
        public object InvalidLabelStyle { get; set; }

        [JsonProperty("label_style")]
        public object LabelStyle { get; set; }

        [JsonProperty("listbox_item_style")]
        public object ListboxItemStyle { get; set; }

        [JsonProperty("listbox_style")]
        public object ListboxStyle { get; set; }

        [JsonProperty("load_game_mod_disabled_listbox_item_style")]
        public object LoadGameModDisabledListboxItemStyle { get; set; }

        [JsonProperty("load_game_mod_invalid_listbox_item_style")]
        public object LoadGameModInvalidListboxItemStyle { get; set; }

        [JsonProperty("load_game_mods_listbox_style")]
        public object LoadGameModsListboxStyle { get; set; }

        [JsonProperty("locked_achievement_frame_style")]
        public object LockedAchievementFrameStyle { get; set; }

        [JsonProperty("logistic_button_selected_slot_style")]
        public object LogisticButtonSelectedSlotStyle { get; set; }

        [JsonProperty("logistic_button_slot_style")]
        public object LogisticButtonSlotStyle { get; set; }

        [JsonProperty("machine_frame_style")]
        public object MachineFrameStyle { get; set; }

        [JsonProperty("machine_right_part_flow_style")]
        public object MachineRightPartFlowStyle { get; set; }

        [JsonProperty("map_settings_dropdown_style")]
        public object MapSettingsDropdownStyle { get; set; }

        [JsonProperty("menu_button_style")]
        public object MenuButtonStyle { get; set; }

        [JsonProperty("menu_frame_style")]
        public object MenuFrameStyle { get; set; }

        [JsonProperty("menu_message_style")]
        public object MenuMessageStyle { get; set; }

        [JsonProperty("minimap_frame_style")]
        public object MinimapFrameStyle { get; set; }

        [JsonProperty("mining_progressbar_style")]
        public object MiningProgressbarStyle { get; set; }

        [JsonProperty("mod_dependency_invalid_label_style")]
        public object ModDependencyInvalidLabelStyle { get; set; }

        [JsonProperty("mod_disabled_listbox_item_style")]
        public object ModDisabledListboxItemStyle { get; set; }

        [JsonProperty("mod_info_flow_style")]
        public object ModInfoFlowStyle { get; set; }

        [JsonProperty("mod_invalid_listbox_item_style")]
        public object ModInvalidListboxItemStyle { get; set; }

        [JsonProperty("mod_list_label_style")]
        public object ModListLabelStyle { get; set; }

        [JsonProperty("mod_updates_available_listbox_item_style")]
        public object ModUpdatesAvailableListboxItemStyle { get; set; }

        [JsonProperty("mods_listbox_style")]
        public object ModsListboxStyle { get; set; }

        [JsonProperty("multiplayer_activity_bar_style")]
        public object MultiplayerActivityBarStyle { get; set; }

        [JsonProperty("naked_frame_style")]
        public object NakedFrameStyle { get; set; }

        [JsonProperty("no_path_station_in_schedule_in_train_view_listbox_item_style")]
        public object NoPathStationInScheduleInTrainViewListboxItemStyle { get; set; }

        [JsonProperty("not_available_preview_technology_slot_style")]
        public object NotAvailablePreviewTechnologySlotStyle { get; set; }

        [JsonProperty("not_available_slot_button_style")]
        public object NotAvailableSlotButtonStyle { get; set; }

        [JsonProperty("not_available_technology_slot_style")]
        public object NotAvailableTechnologySlotStyle { get; set; }

        [JsonProperty("not_working_weapon_button_style")]
        public object NotWorkingWeaponButtonStyle { get; set; }

        [JsonProperty("notice_textbox_style")]
        public object NoticeTextboxStyle { get; set; }

        [JsonProperty("number_textfield_style")]
        public object NumberTextfieldStyle { get; set; }

        [JsonProperty("omitted_technology_slot_style")]
        public object OmittedTechnologySlotStyle { get; set; }

        [JsonProperty("outer_frame_style")]
        public object OuterFrameStyle { get; set; }

        [JsonProperty("partially_promised_crafting_queue_slot_style")]
        public object PartiallyPromisedCraftingQueueSlotStyle { get; set; }

        [JsonProperty("player_listbox_item_style")]
        public object PlayerListboxItemStyle { get; set; }

        [JsonProperty("production_progressbar_style")]
        public object ProductionProgressbarStyle { get; set; }

        [JsonProperty("progressbar_style")]
        public object ProgressbarStyle { get; set; }

        [JsonProperty("promised_crafting_queue_slot_style")]
        public object PromisedCraftingQueueSlotStyle { get; set; }

        [JsonProperty("quick_bar_frame_style")]
        public object QuickBarFrameStyle { get; set; }

        [JsonProperty("radiobutton_style")]
        public object RadiobuttonStyle { get; set; }

        [JsonProperty("recipe_tooltip_cannot_craft_label_style")]
        public object RecipeTooltipCannotCraftLabelStyle { get; set; }

        [JsonProperty("recipe_tooltip_transitive_craft_label_style")]
        public object RecipeTooltipTransitiveCraftLabelStyle { get; set; }

        [JsonProperty("red_circuit_network_content_slot_style")]
        public object RedCircuitNetworkContentSlotStyle { get; set; }

        [JsonProperty("red_slot_button_style")]
        public object RedSlotButtonStyle { get; set; }

        [JsonProperty("researched_preview_technology_slot_style")]
        public object ResearchedPreviewTechnologySlotStyle { get; set; }

        [JsonProperty("researched_technology_slot_style")]
        public object ResearchedTechnologySlotStyle { get; set; }

        [JsonProperty("right_bottom_container_frame_style")]
        public object RightBottomContainerFrameStyle { get; set; }

        [JsonProperty("right_container_frame_style")]
        public object RightContainerFrameStyle { get; set; }

        [JsonProperty("saves_listbox_style")]
        public object SavesListboxStyle { get; set; }

        [JsonProperty("scenario_message_dialog_label_style")]
        public object ScenarioMessageDialogLabelStyle { get; set; }

        [JsonProperty("scenario_message_dialog_style")]
        public object ScenarioMessageDialogStyle { get; set; }

        [JsonProperty("schedule_in_train_view_list_box_style")]
        public object ScheduleInTrainViewListBoxStyle { get; set; }

        [JsonProperty("scroll_pane_style")]
        public object ScrollPaneStyle { get; set; }

        [JsonProperty("scrollbar_style")]
        public object ScrollbarStyle { get; set; }

        [JsonProperty("search_button_style")]
        public object SearchButtonStyle { get; set; }

        [JsonProperty("search_flow_style")]
        public object SearchFlowStyle { get; set; }

        [JsonProperty("search_mods_button_style")]
        public object SearchModsButtonStyle { get; set; }

        [JsonProperty("search_textfield_style")]
        public object SearchTextfieldStyle { get; set; }

        [JsonProperty("selected_slot_button_style")]
        public object SelectedSlotButtonStyle { get; set; }

        [JsonProperty("shield_progressbar_style")]
        public object ShieldProgressbarStyle { get; set; }

        [JsonProperty("side_menu_button_style")]
        public object SideMenuButtonStyle { get; set; }

        [JsonProperty("side_menu_frame_style")]
        public object SideMenuFrameStyle { get; set; }

        [JsonProperty("slider_style")]
        public object SliderStyle { get; set; }

        [JsonProperty("slot_button_style")]
        public object SlotButtonStyle { get; set; }

        [JsonProperty("slot_table_spacing_flow_style")]
        public object SlotTableSpacingFlowStyle { get; set; }

        [JsonProperty("slot_table_style")]
        public object SlotTableStyle { get; set; }

        [JsonProperty("slot_with_filter_button_style")]
        public object SlotWithFilterButtonStyle { get; set; }

        [JsonProperty("small_slot_button_style")]
        public object SmallSlotButtonStyle { get; set; }

        [JsonProperty("statistics_progressbar_style")]
        public object StatisticsProgressbarStyle { get; set; }

        [JsonProperty("steam_friend_listbox_item_style")]
        public object SteamFriendListboxItemStyle { get; set; }

        [JsonProperty("switch_quickbar_button_style")]
        public object SwitchQuickbarButtonStyle { get; set; }

        [JsonProperty("tab_style")]
        public object TabStyle { get; set; }

        [JsonProperty("table_spacing_flow_style")]
        public object TableSpacingFlowStyle { get; set; }

        [JsonProperty("table_style")]
        public object TableStyle { get; set; }

        [JsonProperty("target_station_in_schedule_in_train_view_listbox_item_style")]
        public object TargetStationInScheduleInTrainViewListboxItemStyle { get; set; }

        [JsonProperty("technology_preview_frame_style")]
        public object TechnologyPreviewFrameStyle { get; set; }

        [JsonProperty("technology_slot_button_style")]
        public object TechnologySlotButtonStyle { get; set; }

        [JsonProperty("textbox_style")]
        public object TextboxStyle { get; set; }

        [JsonProperty("textfield_style")]
        public object TextfieldStyle { get; set; }

        [JsonProperty("tool_bar_frame_style")]
        public object ToolBarFrameStyle { get; set; }

        [JsonProperty("tool_equip_gui_label_style")]
        public object ToolEquipGuiLabelStyle { get; set; }

        [JsonProperty("tooltip_description_label_style")]
        public object TooltipDescriptionLabelStyle { get; set; }

        [JsonProperty("tooltip_flow_style")]
        public object TooltipFlowStyle { get; set; }

        [JsonProperty("tooltip_frame_style")]
        public object TooltipFrameStyle { get; set; }

        [JsonProperty("tooltip_label_style")]
        public object TooltipLabelStyle { get; set; }

        [JsonProperty("tooltip_title_label_style")]
        public object TooltipTitleLabelStyle { get; set; }

        [JsonProperty("tracked_achievements_flow_style")]
        public object TrackedAchievementsFlowStyle { get; set; }

        [JsonProperty("tracking_off_button_style")]
        public object TrackingOffButtonStyle { get; set; }

        [JsonProperty("tracking_on_button_style")]
        public object TrackingOnButtonStyle { get; set; }

        [JsonProperty("train_station_listbox_style")]
        public object TrainStationListboxStyle { get; set; }

        [JsonProperty("train_station_schedule_listbox_style")]
        public object TrainStationScheduleListboxStyle { get; set; }

        [JsonProperty("unlocked_achievement_frame_style")]
        public object UnlockedAchievementFrameStyle { get; set; }

        [JsonProperty("vehicle_health_progressbar_style")]
        public object VehicleHealthProgressbarStyle { get; set; }

        [JsonProperty("working_weapon_button_style")]
        public object WorkingWeaponButtonStyle { get; set; }

    }

    [JsonObject("item-request-proxy", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ItemRequestProxy : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("picture")]
        public object Picture { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

    }

    public partial class ItemSubgroup
    {

        [JsonProperty("order")]
        public string Order { get; set; }

    }

    [JsonObject("kill-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class KillAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("damage_type")]
        public string DamageType { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string SteamStatsName { get; set; }

        [JsonProperty("type_to_kill")]
        public string TypeToKill { get; set; }

        [JsonProperty("in_vehicle")]
        public bool InVehicle { get; set; }

        [JsonProperty("personally")]
        public bool Personally { get; set; }

    }

    [JsonObject("leaf-particle", MemberSerialization = MemberSerialization.OptIn)]
    public partial class LeafParticle : TypedNamedBase
    {

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("life_time")]
        public float LifeTime { get; set; }

        [JsonProperty("movement_modifier")]
        public float MovementModifier { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("shadows")]
        public object Shadows { get; set; }

    }

    [JsonObject("loader", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Loader : TypedNamedBase
    {

        [JsonProperty("animation_speed_coefficient")]
        public float AnimationSpeedCoefficient { get; set; }

        [JsonProperty("belt_horizontal")]
        public object BeltHorizontal { get; set; }

        [JsonProperty("belt_vertical")]
        public object BeltVertical { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("ending_bottom")]
        public object EndingBottom { get; set; }

        [JsonProperty("ending_patch")]
        public object EndingPatch { get; set; }

        [JsonProperty("ending_side")]
        public object EndingSide { get; set; }

        [JsonProperty("ending_top")]
        public object EndingTop { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string FastReplaceableGroup { get; set; }

        [JsonProperty("filter_count")]
        public float FilterCount { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("starting_bottom")]
        public object StartingBottom { get; set; }

        [JsonProperty("starting_side")]
        public object StartingSide { get; set; }

        [JsonProperty("starting_top")]
        public object StartingTop { get; set; }

        [JsonProperty("structure")]
        public object Structure { get; set; }

    }

    [JsonObject("module-category", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ModuleCategory : TypedNamedBase
    {

    }

    [JsonObject("offshore-pump", MemberSerialization = MemberSerialization.OptIn)]
    public partial class OffshorePump : TypedNamedBase
    {

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("fluid")]
        public string Fluid { get; set; }

        [JsonProperty("fluid_box")]
        public object FluidBox { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("picture")]
        public object Picture { get; set; }

        [JsonProperty("pumping_speed")]
        public float PumpingSpeed { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("tile_width")]
        public float TileWidth { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("particle-source", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ParticleSource : TypedNamedBase
    {

        [JsonProperty("height")]
        public float Height { get; set; }

        [JsonProperty("height_deviation")]
        public float HeightDeviation { get; set; }

        [JsonProperty("horizontal_speed")]
        public float HorizontalSpeed { get; set; }

        [JsonProperty("horizontal_speed_deviation")]
        public float HorizontalSpeedDeviation { get; set; }

        [JsonProperty("particle")]
        public string Particle { get; set; }

        [JsonProperty("time_before_start")]
        public float TimeBeforeStart { get; set; }

        [JsonProperty("time_before_start_deviation")]
        public float TimeBeforeStartDeviation { get; set; }

        [JsonProperty("time_to_live")]
        public float TimeToLive { get; set; }

        [JsonProperty("time_to_live_deviation")]
        public float TimeToLiveDeviation { get; set; }

        [JsonProperty("vertical_speed")]
        public float VerticalSpeed { get; set; }

        [JsonProperty("vertical_speed_deviation")]
        public float VerticalSpeedDeviation { get; set; }

    }

    [JsonObject("player-damaged-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlayerDamagedAchievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("minimum_damage")]
        public float MinimumDamage { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("should_survive")]
        public bool ShouldSurvive { get; set; }

        [JsonProperty("steam_stats_name")]
        public string SteamStatsName { get; set; }

        [JsonProperty("type_of_dealer")]
        public string TypeOfDealer { get; set; }

    }

    [JsonObject("power-switch", MemberSerialization = MemberSerialization.OptIn)]
    public partial class PowerSwitch : TypedNamedBase
    {

        [JsonProperty("circuit_wire_connection_point")]
        public object CircuitWireConnectionPoint { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("led_off")]
        public object LedOff { get; set; }

        [JsonProperty("led_on")]
        public object LedOn { get; set; }

        [JsonProperty("left_wire_connection_point")]
        public object LeftWireConnectionPoint { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("overlay_loop")]
        public object OverlayLoop { get; set; }

        [JsonProperty("overlay_start")]
        public object OverlayStart { get; set; }

        [JsonProperty("overlay_start_delay")]
        public float OverlayStartDelay { get; set; }

        [JsonProperty("power_on_animation")]
        public object PowerOnAnimation { get; set; }

        [JsonProperty("right_wire_connection_point")]
        public object RightWireConnectionPoint { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("wire_max_distance")]
        public float WireMaxDistance { get; set; }

    }

    [JsonObject("produce-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ProduceAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("item_product")]
        public string ItemProduct { get; set; }

        [JsonProperty("limited_to_one_game")]
        public bool LimitedToOneGame { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string SteamStatsName { get; set; }

    }

    [JsonObject("produce-per-hour-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ProducePerHourAchievement : TypedNamedBase
    {

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("item_product")]
        public string ItemProduct { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string SteamStatsName { get; set; }

    }

    [JsonObject("rail-chain-signal", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RailChainSignal : TypedNamedBase
    {

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("blue_light")]
        public object BlueLight { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string FastReplaceableGroup { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("green_light")]
        public object GreenLight { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("orange_light")]
        public object OrangeLight { get; set; }

        [JsonProperty("rail_piece")]
        public object RailPiece { get; set; }

        [JsonProperty("red_light")]
        public object RedLight { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("selection_box_offsets")]
        public object SelectionBoxOffsets { get; set; }

    }

    [JsonObject("rail-planner", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RailPlanner : TypedNamedBase
    {

        [JsonProperty("curved_rail")]
        public string CurvedRail { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("place_result")]
        public string PlaceResult { get; set; }

        [JsonProperty("stack_size")]
        public float StackSize { get; set; }

        [JsonProperty("straight_rail")]
        public string StraightRail { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("repair-tool", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RepairTool : TypedNamedBase
    {

        [JsonProperty("durability")]
        public float Durability { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("stack_size")]
        public float StackSize { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("research-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ResearchAchievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("technology")]
        public string Technology { get; set; }

        [JsonProperty("research_all")]
        public bool ResearchAll { get; set; }

    }

    [JsonObject("resource-category", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ResourceCategory : TypedNamedBase
    {

    }

    [JsonObject("roboport-equipment", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RoboportEquipment : TypedNamedBase
    {

        [JsonProperty("charge_approach_distance")]
        public float ChargeApproachDistance { get; set; }

        [JsonProperty("charging_distance")]
        public float ChargingDistance { get; set; }

        [JsonProperty("charging_energy")]
        public string ChargingEnergy { get; set; }

        [JsonProperty("charging_station_count")]
        public float ChargingStationCount { get; set; }

        [JsonProperty("charging_station_shift")]
        public object ChargingStationShift { get; set; }

        [JsonProperty("charging_threshold_distance")]
        public float ChargingThresholdDistance { get; set; }

        [JsonProperty("construction_radius")]
        public float ConstructionRadius { get; set; }

        [JsonProperty("energy_consumption")]
        public string EnergyConsumption { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("recharging_animation")]
        public object RechargingAnimation { get; set; }

        [JsonProperty("recharging_light")]
        public object RechargingLight { get; set; }

        [JsonProperty("robot_limit")]
        public float RobotLimit { get; set; }

        [JsonProperty("shape")]
        public object Shape { get; set; }

        [JsonProperty("spawn_and_station_height")]
        public float SpawnAndStationHeight { get; set; }

        [JsonProperty("sprite")]
        public object Sprite { get; set; }

        [JsonProperty("stationing_offset")]
        public object StationingOffset { get; set; }

        [JsonProperty("take_result")]
        public string TakeResult { get; set; }

    }

    [JsonObject("rocket-silo", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RocketSilo : TypedNamedBase
    {

        [JsonProperty("active_energy_usage")]
        public string ActiveEnergyUsage { get; set; }

        [JsonProperty("alarm_trigger")]
        public object AlarmTrigger { get; set; }

        [JsonProperty("allowed_effects")]
        public object AllowedEffects { get; set; }

        [JsonProperty("arm_01_back_animation")]
        public object Arm01BackAnimation { get; set; }

        [JsonProperty("arm_02_right_animation")]
        public object Arm02RightAnimation { get; set; }

        [JsonProperty("arm_03_front_animation")]
        public object Arm03FrontAnimation { get; set; }

        [JsonProperty("base_day_sprite")]
        public object BaseDaySprite { get; set; }

        [JsonProperty("base_engine_light")]
        public object BaseEngineLight { get; set; }

        [JsonProperty("base_front_sprite")]
        public object BaseFrontSprite { get; set; }

        [JsonProperty("base_light")]
        public object BaseLight { get; set; }

        [JsonProperty("base_night_sprite")]
        public object BaseNightSprite { get; set; }

        [JsonProperty("clamps_off_trigger")]
        public object ClampsOffTrigger { get; set; }

        [JsonProperty("clamps_on_trigger")]
        public object ClampsOnTrigger { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("crafting_categories")]
        public object CraftingCategories { get; set; }

        [JsonProperty("crafting_speed")]
        public float CraftingSpeed { get; set; }

        [JsonProperty("door_back_open_offset")]
        public object DoorBackOpenOffset { get; set; }

        [JsonProperty("door_back_sprite")]
        public object DoorBackSprite { get; set; }

        [JsonProperty("door_front_open_offset")]
        public object DoorFrontOpenOffset { get; set; }

        [JsonProperty("door_front_sprite")]
        public object DoorFrontSprite { get; set; }

        [JsonProperty("door_opening_speed")]
        public float DoorOpeningSpeed { get; set; }

        [JsonProperty("doors_trigger")]
        public object DoorsTrigger { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("energy_source")]
        public object EnergySource { get; set; }

        [JsonProperty("energy_usage")]
        public string EnergyUsage { get; set; }

        [JsonProperty("fixed_recipe")]
        public string FixedRecipe { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("hole_light_sprite")]
        public object HoleLightSprite { get; set; }

        [JsonProperty("hole_sprite")]
        public object HoleSprite { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("idle_energy_usage")]
        public string IdleEnergyUsage { get; set; }

        [JsonProperty("ingredient_count")]
        public float IngredientCount { get; set; }

        [JsonProperty("lamp_energy_usage")]
        public string LampEnergyUsage { get; set; }

        [JsonProperty("light_blinking_speed")]
        public float LightBlinkingSpeed { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("module_specification")]
        public object ModuleSpecification { get; set; }

        [JsonProperty("raise_rocket_trigger")]
        public object RaiseRocketTrigger { get; set; }

        [JsonProperty("red_lights_back_sprites")]
        public object RedLightsBackSprites { get; set; }

        [JsonProperty("red_lights_front_sprites")]
        public object RedLightsFrontSprites { get; set; }

        [JsonProperty("rocket_entity")]
        public string RocketEntity { get; set; }

        [JsonProperty("rocket_glow_overlay_sprite")]
        public object RocketGlowOverlaySprite { get; set; }

        [JsonProperty("rocket_parts_required")]
        public float RocketPartsRequired { get; set; }

        [JsonProperty("rocket_shadow_overlay_sprite")]
        public object RocketShadowOverlaySprite { get; set; }

        [JsonProperty("satellite_animation")]
        public object SatelliteAnimation { get; set; }

        [JsonProperty("satellite_shadow_animation")]
        public object SatelliteShadowAnimation { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("shadow_sprite")]
        public object ShadowSprite { get; set; }

        [JsonProperty("silo_fade_out_end_distance")]
        public float SiloFadeOutEndDistance { get; set; }

        [JsonProperty("silo_fade_out_start_distance")]
        public float SiloFadeOutStartDistance { get; set; }

        [JsonProperty("times_to_blink")]
        public float TimesToBlink { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

    }

    [JsonObject("rocket-silo-rocket", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RocketSiloRocket : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("collision_mask")]
        public object CollisionMask { get; set; }

        [JsonProperty("dying_explosion")]
        public string DyingExplosion { get; set; }

        [JsonProperty("effects_fade_in_end_distance")]
        public float EffectsFadeInEndDistance { get; set; }

        [JsonProperty("effects_fade_in_start_distance")]
        public float EffectsFadeInStartDistance { get; set; }

        [JsonProperty("engine_starting_speed")]
        public float EngineStartingSpeed { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("flying_acceleration")]
        public float FlyingAcceleration { get; set; }

        [JsonProperty("flying_speed")]
        public float FlyingSpeed { get; set; }

        [JsonProperty("flying_trigger")]
        public object FlyingTrigger { get; set; }

        [JsonProperty("full_render_layer_switch_distance")]
        public float FullRenderLayerSwitchDistance { get; set; }

        [JsonProperty("glow_light")]
        public object GlowLight { get; set; }

        [JsonProperty("inventory_size")]
        public float InventorySize { get; set; }

        [JsonProperty("rising_speed")]
        public float RisingSpeed { get; set; }

        [JsonProperty("rocket_flame_animation")]
        public object RocketFlameAnimation { get; set; }

        [JsonProperty("rocket_flame_left_animation")]
        public object RocketFlameLeftAnimation { get; set; }

        [JsonProperty("rocket_flame_left_rotation")]
        public float RocketFlameLeftRotation { get; set; }

        [JsonProperty("rocket_flame_right_animation")]
        public object RocketFlameRightAnimation { get; set; }

        [JsonProperty("rocket_flame_right_rotation")]
        public float RocketFlameRightRotation { get; set; }

        [JsonProperty("rocket_glare_overlay_sprite")]
        public object RocketGlareOverlaySprite { get; set; }

        [JsonProperty("rocket_launch_offset")]
        public object RocketLaunchOffset { get; set; }

        [JsonProperty("rocket_render_layer_switch_distance")]
        public float RocketRenderLayerSwitchDistance { get; set; }

        [JsonProperty("rocket_rise_offset")]
        public object RocketRiseOffset { get; set; }

        [JsonProperty("rocket_shadow_sprite")]
        public object RocketShadowSprite { get; set; }

        [JsonProperty("rocket_smoke_bottom1_animation")]
        public object RocketSmokeBottom1Animation { get; set; }

        [JsonProperty("rocket_smoke_bottom2_animation")]
        public object RocketSmokeBottom2Animation { get; set; }

        [JsonProperty("rocket_smoke_top1_animation")]
        public object RocketSmokeTop1Animation { get; set; }

        [JsonProperty("rocket_smoke_top2_animation")]
        public object RocketSmokeTop2Animation { get; set; }

        [JsonProperty("rocket_smoke_top3_animation")]
        public object RocketSmokeTop3Animation { get; set; }

        [JsonProperty("rocket_sprite")]
        public object RocketSprite { get; set; }

        [JsonProperty("rocket_visible_distance_from_center")]
        public float RocketVisibleDistanceFromCenter { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("shadow_fade_out_end_ratio")]
        public float ShadowFadeOutEndRatio { get; set; }

        [JsonProperty("shadow_fade_out_start_ratio")]
        public float ShadowFadeOutStartRatio { get; set; }

        [JsonProperty("shadow_slave_entity")]
        public string ShadowSlaveEntity { get; set; }

    }

    [JsonObject("rocket-silo-rocket-shadow", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RocketSiloRocketShadow : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("collision_mask")]
        public object CollisionMask { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

    }

    [JsonObject("selection-tool", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SelectionTool : TypedNamedBase
    {

        [JsonProperty("alt_selection_color")]
        public object AltSelectionColor { get; set; }

        [JsonProperty("alt_selection_cursor_box_type")]
        public string AltSelectionCursorBoxType { get; set; }

        [JsonProperty("alt_selection_mode")]
        public object AltSelectionMode { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("localised_name")]
        public object LocalisedName { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("selection_color")]
        public object SelectionColor { get; set; }

        [JsonProperty("selection_cursor_box_type")]
        public string SelectionCursorBoxType { get; set; }

        [JsonProperty("selection_mode")]
        public object SelectionMode { get; set; }

        [JsonProperty("stack_size")]
        public float StackSize { get; set; }

        [JsonProperty("stackable")]
        public bool Stackable { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("simple-entity", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SimpleEntity : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("render_layer")]
        public string RenderLayer { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("autoplace")]
        public object Autoplace { get; set; }

        [JsonProperty("loot")]
        public object Loot { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("mined_sound")]
        public object MinedSound { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

    }

    [JsonObject("smoke-with-trigger", MemberSerialization = MemberSerialization.OptIn)]
    public partial class SmokeWithTrigger : TypedNamedBase
    {

        [JsonProperty("action")]
        public object Action { get; set; }

        [JsonProperty("action_frequency")]
        public float ActionFrequency { get; set; }

        [JsonProperty("affected_by_wind")]
        public bool AffectedByWind { get; set; }

        [JsonProperty("animation")]
        public object Animation { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("cyclic")]
        public bool Cyclic { get; set; }

        [JsonProperty("duration")]
        public float Duration { get; set; }

        [JsonProperty("fade_away_duration")]
        public float FadeAwayDuration { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("show_when_smoke_off")]
        public bool ShowWhenSmokeOff { get; set; }

        [JsonProperty("slow_down_factor")]
        public float SlowDownFactor { get; set; }

        [JsonProperty("spread_duration")]
        public float SpreadDuration { get; set; }

    }

    [JsonObject("storage-tank", MemberSerialization = MemberSerialization.OptIn)]
    public partial class StorageTank : TypedNamedBase
    {

        [JsonProperty("circuit_connector_sprites")]
        public object CircuitConnectorSprites { get; set; }

        [JsonProperty("circuit_wire_connection_points")]
        public object CircuitWireConnectionPoints { get; set; }

        [JsonProperty("circuit_wire_max_distance")]
        public float CircuitWireMaxDistance { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string FastReplaceableGroup { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("flow_length_in_ticks")]
        public float FlowLengthInTicks { get; set; }

        [JsonProperty("fluid_box")]
        public object FluidBox { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("vehicle_impact_sound")]
        public object VehicleImpactSound { get; set; }

        [JsonProperty("window_bounding_box")]
        public object WindowBoundingBox { get; set; }

        [JsonProperty("working_sound")]
        public object WorkingSound { get; set; }

    }

    [JsonObject("straight-rail", MemberSerialization = MemberSerialization.OptIn)]
    public partial class StraightRail : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("pictures")]
        public object Pictures { get; set; }

        [JsonProperty("rail_category")]
        public string RailCategory { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

    }

    [JsonObject("stream", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Stream : TypedNamedBase
    {

        [JsonProperty("action")]
        public object Action { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("ground_light")]
        public object GroundLight { get; set; }

        [JsonProperty("particle")]
        public object Particle { get; set; }

        [JsonProperty("particle_buffer_size")]
        public float ParticleBufferSize { get; set; }

        [JsonProperty("particle_end_alpha")]
        public float ParticleEndAlpha { get; set; }

        [JsonProperty("particle_fade_out_threshold")]
        public float ParticleFadeOutThreshold { get; set; }

        [JsonProperty("particle_horizontal_speed")]
        public float ParticleHorizontalSpeed { get; set; }

        [JsonProperty("particle_horizontal_speed_deviation")]
        public float ParticleHorizontalSpeedDeviation { get; set; }

        [JsonProperty("particle_loop_exit_threshold")]
        public float ParticleLoopExitThreshold { get; set; }

        [JsonProperty("particle_loop_frame_count")]
        public float ParticleLoopFrameCount { get; set; }

        [JsonProperty("particle_spawn_interval")]
        public float ParticleSpawnInterval { get; set; }

        [JsonProperty("particle_spawn_timeout")]
        public float ParticleSpawnTimeout { get; set; }

        [JsonProperty("particle_start_alpha")]
        public float ParticleStartAlpha { get; set; }

        [JsonProperty("particle_start_scale")]
        public float ParticleStartScale { get; set; }

        [JsonProperty("particle_vertical_acceleration")]
        public float ParticleVerticalAcceleration { get; set; }

        [JsonProperty("shadow")]
        public object Shadow { get; set; }

        [JsonProperty("smoke_sources")]
        public object SmokeSources { get; set; }

        [JsonProperty("spine_animation")]
        public object SpineAnimation { get; set; }

        [JsonProperty("stream_light")]
        public object StreamLight { get; set; }

        [JsonProperty("working_sound_disabled")]
        public object WorkingSoundDisabled { get; set; }

    }

    [JsonObject("tile-ghost", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TileGhost : TypedNamedBase
    {

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

    }

    [JsonObject("tool", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Tool : TypedNamedBase
    {

        [JsonProperty("durability")]
        public float Durability { get; set; }

        [JsonProperty("durability_description_key")]
        public string DurabilityDescriptionKey { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("stack_size")]
        public float StackSize { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

    }

    [JsonObject("train-path-achievement", MemberSerialization = MemberSerialization.OptIn)]
    public partial class TrainPathAchievement : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("minimum_distance")]
        public float MinimumDistance { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("steam_stats_name")]
        public string SteamStatsName { get; set; }

    }

    [JsonObject("underground-belt", MemberSerialization = MemberSerialization.OptIn)]
    public partial class UndergroundBelt : TypedNamedBase
    {

        [JsonProperty("animation_speed_coefficient")]
        public float AnimationSpeedCoefficient { get; set; }

        [JsonProperty("belt_horizontal")]
        public object BeltHorizontal { get; set; }

        [JsonProperty("belt_vertical")]
        public object BeltVertical { get; set; }

        [JsonProperty("collision_box")]
        public object CollisionBox { get; set; }

        [JsonProperty("corpse")]
        public string Corpse { get; set; }

        [JsonProperty("ending_bottom")]
        public object EndingBottom { get; set; }

        [JsonProperty("ending_patch")]
        public object EndingPatch { get; set; }

        [JsonProperty("ending_side")]
        public object EndingSide { get; set; }

        [JsonProperty("ending_top")]
        public object EndingTop { get; set; }

        [JsonProperty("fast_replaceable_group")]
        public string FastReplaceableGroup { get; set; }

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("max_distance")]
        public float MaxDistance { get; set; }

        [JsonProperty("max_health")]
        public float MaxHealth { get; set; }

        [JsonProperty("minable")]
        public object Minable { get; set; }

        [JsonProperty("resistances")]
        public object Resistances { get; set; }

        [JsonProperty("selection_box")]
        public object SelectionBox { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("starting_bottom")]
        public object StartingBottom { get; set; }

        [JsonProperty("starting_side")]
        public object StartingSide { get; set; }

        [JsonProperty("starting_top")]
        public object StartingTop { get; set; }

        [JsonProperty("structure")]
        public object Structure { get; set; }

        [JsonProperty("underground_sprite")]
        public object UndergroundSprite { get; set; }

        [JsonProperty("distance_to_enter")]
        public float DistanceToEnter { get; set; }

    }

    [JsonObject("utility-sprites", MemberSerialization = MemberSerialization.OptIn)]
    public partial class UtilitySprites : TypedNamedBase
    {

        [JsonProperty("arrow_button")]
        public object ArrowButton { get; set; }

        [JsonProperty("battery_indicator")]
        public object BatteryIndicator { get; set; }

        [JsonProperty("fluid_indication_arrow")]
        public object FluidIndicationArrow { get; set; }

        [JsonProperty("grey_placement_indicator_leg")]
        public object GreyPlacementIndicatorLeg { get; set; }

        [JsonProperty("grey_rail_signal_placement_indicator")]
        public object GreyRailSignalPlacementIndicator { get; set; }

        [JsonProperty("indication_arrow")]
        public object IndicationArrow { get; set; }

        [JsonProperty("indication_line")]
        public object IndicationLine { get; set; }

        [JsonProperty("placement_indicator_leg")]
        public object PlacementIndicatorLeg { get; set; }

        [JsonProperty("rail_planner_indication_arrow")]
        public object RailPlannerIndicationArrow { get; set; }

        [JsonProperty("rail_planner_indication_arrow_too_far")]
        public object RailPlannerIndicationArrowTooFar { get; set; }

        [JsonProperty("rail_signal_placement_indicator")]
        public object RailSignalPlacementIndicator { get; set; }

        [JsonProperty("reset")]
        public object Reset { get; set; }

        [JsonProperty("short_indication_line")]
        public object ShortIndicationLine { get; set; }

        [JsonProperty("train_stop_placement_indicator")]
        public object TrainStopPlacementIndicator { get; set; }

    }

    [JsonObject("virtual-signal", MemberSerialization = MemberSerialization.OptIn)]
    public partial class VirtualSignal : TypedNamedBase
    {

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("special_signal")]
        public bool SpecialSignal { get; set; }

    }

}
////*************************************************************************************
////
////     G E N E R A T E D   C L A S S E S
////
////*************************************************************************************

//using Newtonsoft.Json;

//namespace lua.reader
//{

//    [JsonObject("ammo-category", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class AmmoCategory : TypedNamedBase
//    {

//    }

//    [JsonObject("autoplace-control", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class AutoplaceControl : TypedNamedBase
//    {

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("richness")]
//        public object Richness { get; set; }

//    }

//    [JsonObject("damage-type", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class DamageType : TypedNamedBase
//    {

//    }

//    [JsonObject("arrow", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Arrow : Entity
//    {

//        [JsonProperty("arrow_picture")]
//        public object ArrowPicture { get; set; }

//        [JsonProperty("blinking")]
//        public object Blinking { get; set; }

//        [JsonProperty("circle_picture")]
//        public object CirclePicture { get; set; }

//    }

//    [JsonObject("corpse", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Corpse : Entity
//    {

//        [JsonProperty("final_render_layer")]
//        public object FinalRenderLayer { get; set; }

//        [JsonProperty("splash")]
//        public object Splash { get; set; }

//        [JsonProperty("splash_speed")]
//        public object SplashSpeed { get; set; }

//        [JsonProperty("time_before_removed")]
//        public object TimeBeforeRemoved { get; set; }

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("dying_speed")]
//        public object DyingSpeed { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("selectable_in_game")]
//        public object SelectableInGame { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("collision_mask")]
//        public object CollisionMask { get; set; }

//        [JsonProperty("ground_patch")]
//        public object GroundPatch { get; set; }

//        [JsonProperty("ground_patch_higher")]
//        public object GroundPatchHigher { get; set; }

//    }

//    [JsonObject("decorative", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Decorative : Entity
//    {

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("render_layer")]
//        public object RenderLayer { get; set; }

//        [JsonProperty("selectable_in_game")]
//        public object SelectableInGame { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("explosion", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Explosion : Entity
//    {

//        [JsonProperty("animations")]
//        public object Animations { get; set; }

//        [JsonProperty("created_effect")]
//        public object CreatedEffect { get; set; }

//        [JsonProperty("light")]
//        public object Light { get; set; }

//        [JsonProperty("sound")]
//        public object Sound { get; set; }

//        [JsonProperty("smoke")]
//        public object Smoke { get; set; }

//        [JsonProperty("smoke_count")]
//        public object SmokeCount { get; set; }

//        [JsonProperty("smoke_slow_down_factor")]
//        public object SmokeSlowDownFactor { get; set; }

//        [JsonProperty("rotate")]
//        public object Rotate { get; set; }

//        [JsonProperty("animation_speed")]
//        public object AnimationSpeed { get; set; }

//        [JsonProperty("beam")]
//        public object Beam { get; set; }

//    }

//    [JsonObject("flame-thrower-explosion", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class FlameThrowerExplosion : Explosion
//    {

//    }

//    [JsonObject("Prototype/EntityWithHealth", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class EntityWithHealth : Entity
//    {

//    }

//    [JsonObject("accumulator", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Accumulator : EntityWithHealth
//    {

//        [JsonProperty("charge_animation")]
//        public object ChargeAnimation { get; set; }

//        [JsonProperty("charge_cooldown")]
//        public object ChargeCooldown { get; set; }

//        [JsonProperty("charge_light")]
//        public object ChargeLight { get; set; }

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_point")]
//        public object CircuitWireConnectionPoint { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("default_output_signal")]
//        public object DefaultOutputSignal { get; set; }

//        [JsonProperty("discharge_animation")]
//        public object DischargeAnimation { get; set; }

//        [JsonProperty("discharge_cooldown")]
//        public object DischargeCooldown { get; set; }

//        [JsonProperty("discharge_light")]
//        public object DischargeLight { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("picture")]
//        public object Picture { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("assembling-machine", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class AssemblingMachine : EntityWithHealth
//    {

//        [JsonProperty("allowed_effects")]
//        public object AllowedEffects { get; set; }

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("crafting_categories")]
//        public object CraftingCategories { get; set; }

//        [JsonProperty("crafting_speed")]
//        public object CraftingSpeed { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage")]
//        public object EnergyUsage { get; set; }

//        [JsonProperty("fluid_boxes")]
//        public object FluidBoxes { get; set; }

//        [JsonProperty("ingredient_count")]
//        public object IngredientCount { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("module_specification")]
//        public object ModuleSpecification { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("close_sound")]
//        public object CloseSound { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("open_sound")]
//        public object OpenSound { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//        [JsonProperty("working_visualisations")]
//        public object WorkingVisualisations { get; set; }

//        [JsonProperty("mined_sound")]
//        public object MinedSound { get; set; }

//        [JsonProperty("repair_sound")]
//        public object RepairSound { get; set; }

//        [JsonProperty("has_backer_name")]
//        public object HasBackerName { get; set; }

//        [JsonProperty("pipe_covers")]
//        public object PipeCovers { get; set; }

//    }

//    [JsonObject("beacon", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Beacon : EntityWithHealth
//    {

//        [JsonProperty("allowed_effects")]
//        public object AllowedEffects { get; set; }

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("animation_shadow")]
//        public object AnimationShadow { get; set; }

//        [JsonProperty("base_picture")]
//        public object BasePicture { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("distribution_effectivity")]
//        public object DistributionEffectivity { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage")]
//        public object EnergyUsage { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("module_specification")]
//        public object ModuleSpecification { get; set; }

//        [JsonProperty("radius_visualisation_picture")]
//        public object RadiusVisualisationPicture { get; set; }

//        [JsonProperty("supply_area_distance")]
//        public object SupplyAreaDistance { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("car", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Car : EntityWithHealth
//    {

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("braking_power")]
//        public object BrakingPower { get; set; }

//        [JsonProperty("burner")]
//        public object Burner { get; set; }

//        [JsonProperty("close_sound")]
//        public object CloseSound { get; set; }

//        [JsonProperty("consumption")]
//        public object Consumption { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("crash_trigger")]
//        public object CrashTrigger { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("effectivity")]
//        public object Effectivity { get; set; }

//        [JsonProperty("energy_per_hit_point")]
//        public object EnergyPerHitPoint { get; set; }

//        [JsonProperty("friction")]
//        public object Friction { get; set; }

//        [JsonProperty("guns")]
//        public object Guns { get; set; }

//        [JsonProperty("inventory_size")]
//        public object InventorySize { get; set; }

//        [JsonProperty("light")]
//        public object Light { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("open_sound")]
//        public object OpenSound { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("rotation_speed")]
//        public object RotationSpeed { get; set; }

//        [JsonProperty("sound_minimum_speed")]
//        public object SoundMinimumSpeed { get; set; }

//        [JsonProperty("sound_no_fuel")]
//        public object SoundNoFuel { get; set; }

//        [JsonProperty("stop_trigger")]
//        public object StopTrigger { get; set; }

//        [JsonProperty("stop_trigger_speed")]
//        public object StopTriggerSpeed { get; set; }

//        [JsonProperty("turret_animation")]
//        public object TurretAnimation { get; set; }

//        [JsonProperty("turret_rotation_speed")]
//        public object TurretRotationSpeed { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//        [JsonProperty("tank_driving")]
//        public object TankDriving { get; set; }

//        [JsonProperty("terrain_friction_modifier")]
//        public object TerrainFrictionModifier { get; set; }

//        [JsonProperty("turret_return_timeout")]
//        public object TurretReturnTimeout { get; set; }

//    }

//    [JsonObject("player", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Player : EntityWithHealth
//    {

//        [JsonProperty("alert_when_damaged")]
//        public object AlertWhenDamaged { get; set; }

//        [JsonProperty("animations")]
//        public object Animations { get; set; }

//        [JsonProperty("build_distance")]
//        public object BuildDistance { get; set; }

//        [JsonProperty("crafting_categories")]
//        public object CraftingCategories { get; set; }

//        [JsonProperty("damage_hit_tint")]
//        public object DamageHitTint { get; set; }

//        [JsonProperty("distance_per_frame")]
//        public object DistancePerFrame { get; set; }

//        [JsonProperty("drop_item_distance")]
//        public object DropItemDistance { get; set; }

//        [JsonProperty("eat")]
//        public object Eat { get; set; }

//        [JsonProperty("healing_per_tick")]
//        public object HealingPerTick { get; set; }

//        [JsonProperty("heartbeat")]
//        public object Heartbeat { get; set; }

//        [JsonProperty("inventory_size")]
//        public object InventorySize { get; set; }

//        [JsonProperty("item_pickup_distance")]
//        public object ItemPickupDistance { get; set; }

//        [JsonProperty("light")]
//        public object Light { get; set; }

//        [JsonProperty("loot_pickup_distance")]
//        public object LootPickupDistance { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("maximum_corner_sliding_distance")]
//        public object MaximumCornerSlidingDistance { get; set; }

//        [JsonProperty("mining_categories")]
//        public object MiningCategories { get; set; }

//        [JsonProperty("mining_speed")]
//        public object MiningSpeed { get; set; }

//        [JsonProperty("mining_with_hands_particles_animation_positions")]
//        public object MiningWithHandsParticlesAnimationPositions { get; set; }

//        [JsonProperty("mining_with_tool_particles_animation_positions")]
//        public object MiningWithToolParticlesAnimationPositions { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("reach_distance")]
//        public object ReachDistance { get; set; }

//        [JsonProperty("reach_resource_distance")]
//        public object ReachResourceDistance { get; set; }

//        [JsonProperty("running_sound_animation_positions")]
//        public object RunningSoundAnimationPositions { get; set; }

//        [JsonProperty("running_speed")]
//        public object RunningSpeed { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("ticks_to_keep_aiming_direction")]
//        public object TicksToKeepAimingDirection { get; set; }

//        [JsonProperty("ticks_to_keep_gun")]
//        public object TicksToKeepGun { get; set; }

//    }

//    [JsonObject("container", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Container : EntityWithHealth
//    {

//        [JsonProperty("enable_inventory_bar")]
//        public object EnableInventoryBar { get; set; }

//        [JsonProperty("inventory_size")]
//        public object InventorySize { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("picture")]
//        public object Picture { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_point")]
//        public object CircuitWireConnectionPoint { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("close_sound")]
//        public object CloseSound { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("open_sound")]
//        public object OpenSound { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//    }

//    [JsonObject("smart-container", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class SmartContainer : Container
//    {

//    }

//    [JsonObject("logistic-container", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class LogisticContainer : SmartContainer
//    {

//        [JsonProperty("logistic_mode")]
//        public object LogisticMode { get; set; }

//    }

//    [JsonObject("electric-pole", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ElectricPole : EntityWithHealth
//    {

//        [JsonProperty("connection_points")]
//        public object ConnectionPoints { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("maximum_wire_distance")]
//        public object MaximumWireDistance { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("radius_visualisation_picture")]
//        public object RadiusVisualisationPicture { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("supply_area_distance")]
//        public object SupplyAreaDistance { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("copper_wire_picture")]
//        public object CopperWirePicture { get; set; }

//        [JsonProperty("green_wire_picture")]
//        public object GreenWirePicture { get; set; }

//        [JsonProperty("red_wire_picture")]
//        public object RedWirePicture { get; set; }

//        [JsonProperty("wire_shadow_picture")]
//        public object WireShadowPicture { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("fish", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Fish : EntityWithHealth
//    {

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("furnace", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Furnace : EntityWithHealth
//    {

//        [JsonProperty("allowed_effects")]
//        public object AllowedEffects { get; set; }

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("crafting_categories")]
//        public object CraftingCategories { get; set; }

//        [JsonProperty("crafting_speed")]
//        public object CraftingSpeed { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage")]
//        public object EnergyUsage { get; set; }

//        [JsonProperty("light")]
//        public object Light { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("module_specification")]
//        public object ModuleSpecification { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("result_inventory_size")]
//        public object ResultInventorySize { get; set; }

//        [JsonProperty("source_inventory_size")]
//        public object SourceInventorySize { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//        [JsonProperty("working_visualisations")]
//        public object WorkingVisualisations { get; set; }

//        [JsonProperty("close_sound")]
//        public object CloseSound { get; set; }

//        [JsonProperty("mined_sound")]
//        public object MinedSound { get; set; }

//        [JsonProperty("open_sound")]
//        public object OpenSound { get; set; }

//        [JsonProperty("repair_sound")]
//        public object RepairSound { get; set; }

//        [JsonProperty("fluid_boxes")]
//        public object FluidBoxes { get; set; }

//    }

//    [JsonObject("inserter", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Inserter : EntityWithHealth
//    {

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_point")]
//        public object CircuitWireConnectionPoint { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("energy_per_movement")]
//        public object EnergyPerMovement { get; set; }

//        [JsonProperty("energy_per_rotation")]
//        public object EnergyPerRotation { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("extension_speed")]
//        public object ExtensionSpeed { get; set; }

//        [JsonProperty("hand_base_picture")]
//        public object HandBasePicture { get; set; }

//        [JsonProperty("hand_base_shadow")]
//        public object HandBaseShadow { get; set; }

//        [JsonProperty("hand_closed_picture")]
//        public object HandClosedPicture { get; set; }

//        [JsonProperty("hand_closed_shadow")]
//        public object HandClosedShadow { get; set; }

//        [JsonProperty("hand_open_picture")]
//        public object HandOpenPicture { get; set; }

//        [JsonProperty("hand_open_shadow")]
//        public object HandOpenShadow { get; set; }

//        [JsonProperty("hand_size")]
//        public object HandSize { get; set; }

//        [JsonProperty("insert_position")]
//        public object InsertPosition { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("pickup_position")]
//        public object PickupPosition { get; set; }

//        [JsonProperty("platform_picture")]
//        public object PlatformPicture { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("rotation_speed")]
//        public object RotationSpeed { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//        [JsonProperty("filter_count")]
//        public object FilterCount { get; set; }

//        [JsonProperty("stack")]
//        public object Stack { get; set; }

//    }

//    [JsonObject("lab", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Lab : EntityWithHealth
//    {

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage")]
//        public object EnergyUsage { get; set; }

//        [JsonProperty("inputs")]
//        public object Inputs { get; set; }

//        [JsonProperty("light")]
//        public object Light { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("module_specification")]
//        public object ModuleSpecification { get; set; }

//        [JsonProperty("off_animation")]
//        public object OffAnimation { get; set; }

//        [JsonProperty("on_animation")]
//        public object OnAnimation { get; set; }

//        [JsonProperty("researching_speed")]
//        public object ResearchingSpeed { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("lamp", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Lamp : EntityWithHealth
//    {

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_point")]
//        public object CircuitWireConnectionPoint { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage_per_tick")]
//        public object EnergyUsagePerTick { get; set; }

//        [JsonProperty("glow_color_intensity")]
//        public object GlowColorIntensity { get; set; }

//        [JsonProperty("glow_size")]
//        public object GlowSize { get; set; }

//        [JsonProperty("light")]
//        public object Light { get; set; }

//        [JsonProperty("light_when_colored")]
//        public object LightWhenColored { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("picture_off")]
//        public object PictureOff { get; set; }

//        [JsonProperty("picture_on")]
//        public object PictureOn { get; set; }

//        [JsonProperty("signal_to_color_mapping")]
//        public object SignalToColorMapping { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("market", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Market : EntityWithHealth
//    {

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("picture")]
//        public object Picture { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("mining-drill", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class MiningDrill : EntityWithHealth
//    {

//        [JsonProperty("animations")]
//        public object Animations { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage")]
//        public object EnergyUsage { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("mining_power")]
//        public object MiningPower { get; set; }

//        [JsonProperty("mining_speed")]
//        public object MiningSpeed { get; set; }

//        [JsonProperty("module_specification")]
//        public object ModuleSpecification { get; set; }

//        [JsonProperty("radius_visualisation_picture")]
//        public object RadiusVisualisationPicture { get; set; }

//        [JsonProperty("resource_categories")]
//        public object ResourceCategories { get; set; }

//        [JsonProperty("resource_searching_radius")]
//        public object ResourceSearchingRadius { get; set; }

//        [JsonProperty("storage_slots")]
//        public object StorageSlots { get; set; }

//        [JsonProperty("vector_to_place_result")]
//        public object VectorToPlaceResult { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//        [JsonProperty("base_picture")]
//        public object BasePicture { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("fluid_box")]
//        public object FluidBox { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("Prototype/PipeConnectable", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class PipeConnectable : EntityWithHealth
//    {

//    }

//    [JsonObject("boiler", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Boiler : PipeConnectable
//    {

//        [JsonProperty("burner")]
//        public object Burner { get; set; }

//        [JsonProperty("burning_cooldown")]
//        public object BurningCooldown { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("energy_consumption")]
//        public object EnergyConsumption { get; set; }

//        [JsonProperty("fire")]
//        public object Fire { get; set; }

//        [JsonProperty("fluid_box")]
//        public object FluidBox { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("structure")]
//        public object Structure { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("generator", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Generator : PipeConnectable
//    {

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("effectivity")]
//        public object Effectivity { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("fluid_box")]
//        public object FluidBox { get; set; }

//        [JsonProperty("fluid_usage_per_tick")]
//        public object FluidUsagePerTick { get; set; }

//        [JsonProperty("horizontal_animation")]
//        public object HorizontalAnimation { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("min_perceived_performance")]
//        public object MinPerceivedPerformance { get; set; }

//        [JsonProperty("performance_to_sound_speedup")]
//        public object PerformanceToSoundSpeedup { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("smoke")]
//        public object Smoke { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("vertical_animation")]
//        public object VerticalAnimation { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("pump", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Pump : PipeConnectable
//    {

//        [JsonProperty("animations")]
//        public object Animations { get; set; }

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_points")]
//        public object CircuitWireConnectionPoints { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage")]
//        public object EnergyUsage { get; set; }

//        [JsonProperty("fluid_box")]
//        public object FluidBox { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("pumping_speed")]
//        public object PumpingSpeed { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("pipe", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Pipe : PipeConnectable
//    {

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("fluid_box")]
//        public object FluidBox { get; set; }

//        [JsonProperty("horizontal_window_bounding_box")]
//        public object HorizontalWindowBoundingBox { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("vertical_window_bounding_box")]
//        public object VerticalWindowBoundingBox { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("pipe-to-ground", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class PipeToGround : PipeConnectable
//    {

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("fluid_box")]
//        public object FluidBox { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("underground_sprite")]
//        public object UndergroundSprite { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("player-port", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class PlayerPort : EntityWithHealth
//    {

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//    }

//    [JsonObject("radar", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Radar : EntityWithHealth
//    {

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("energy_per_nearby_scan")]
//        public object EnergyPerNearbyScan { get; set; }

//        [JsonProperty("energy_per_sector")]
//        public object EnergyPerSector { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage")]
//        public object EnergyUsage { get; set; }

//        [JsonProperty("max_distance_of_nearby_sector_revealed")]
//        public object MaxDistanceOfNearbySectorRevealed { get; set; }

//        [JsonProperty("max_distance_of_sector_revealed")]
//        public object MaxDistanceOfSectorRevealed { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("rail", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Rail : EntityWithHealth
//    {

//    }

//    [JsonObject("rail-signal", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RailSignal : EntityWithHealth
//    {

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_points")]
//        public object CircuitWireConnectionPoints { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("default_green_output_signal")]
//        public object DefaultGreenOutputSignal { get; set; }

//        [JsonProperty("default_orange_output_signal")]
//        public object DefaultOrangeOutputSignal { get; set; }

//        [JsonProperty("default_red_output_signal")]
//        public object DefaultRedOutputSignal { get; set; }

//        [JsonProperty("green_light")]
//        public object GreenLight { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("orange_light")]
//        public object OrangeLight { get; set; }

//        [JsonProperty("red_light")]
//        public object RedLight { get; set; }

//    }

//    [JsonObject("roboport", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Roboport : EntityWithHealth
//    {

//        [JsonProperty("base")]
//        public object Base { get; set; }

//        [JsonProperty("base_animation")]
//        public object BaseAnimation { get; set; }

//        [JsonProperty("base_patch")]
//        public object BasePatch { get; set; }

//        [JsonProperty("charge_approach_distance")]
//        public object ChargeApproachDistance { get; set; }

//        [JsonProperty("charging_energy")]
//        public object ChargingEnergy { get; set; }

//        [JsonProperty("construction_radius")]
//        public object ConstructionRadius { get; set; }

//        [JsonProperty("construction_radius_visualisation_picture")]
//        public object ConstructionRadiusVisualisationPicture { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("door_animation_down")]
//        public object DoorAnimationDown { get; set; }

//        [JsonProperty("door_animation_up")]
//        public object DoorAnimationUp { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage")]
//        public object EnergyUsage { get; set; }

//        [JsonProperty("logistics_radius")]
//        public object LogisticsRadius { get; set; }

//        [JsonProperty("material_slots_count")]
//        public object MaterialSlotsCount { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("radius_visualisation_picture")]
//        public object RadiusVisualisationPicture { get; set; }

//        [JsonProperty("recharge_minimum")]
//        public object RechargeMinimum { get; set; }

//        [JsonProperty("recharging_animation")]
//        public object RechargingAnimation { get; set; }

//        [JsonProperty("recharging_light")]
//        public object RechargingLight { get; set; }

//        [JsonProperty("request_to_open_door_timeout")]
//        public object RequestToOpenDoorTimeout { get; set; }

//        [JsonProperty("robot_slots_count")]
//        public object RobotSlotsCount { get; set; }

//        [JsonProperty("spawn_and_station_height")]
//        public object SpawnAndStationHeight { get; set; }

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_point")]
//        public object CircuitWireConnectionPoint { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("close_door_trigger_effect")]
//        public object CloseDoorTriggerEffect { get; set; }

//        [JsonProperty("default_available_construction_output_signal")]
//        public object DefaultAvailableConstructionOutputSignal { get; set; }

//        [JsonProperty("default_available_logistic_output_signal")]
//        public object DefaultAvailableLogisticOutputSignal { get; set; }

//        [JsonProperty("default_total_construction_output_signal")]
//        public object DefaultTotalConstructionOutputSignal { get; set; }

//        [JsonProperty("default_total_logistic_output_signal")]
//        public object DefaultTotalLogisticOutputSignal { get; set; }

//        [JsonProperty("open_door_trigger_effect")]
//        public object OpenDoorTriggerEffect { get; set; }

//        [JsonProperty("stationing_offset")]
//        public object StationingOffset { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//        [JsonProperty("charging_offsets")]
//        public object ChargingOffsets { get; set; }

//        [JsonProperty("draw_construction_radius_visualization")]
//        public object DrawConstructionRadiusVisualization { get; set; }

//        [JsonProperty("draw_logistic_radius_visualization")]
//        public object DrawLogisticRadiusVisualization { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("Prototype/Robot", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Robot : EntityWithHealth
//    {

//    }

//    [JsonObject("combat-robot", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class CombatRobot : Robot
//    {

//        [JsonProperty("alert_when_damaged")]
//        public object AlertWhenDamaged { get; set; }

//        [JsonProperty("attack_parameters")]
//        public object AttackParameters { get; set; }

//        [JsonProperty("destroy_action")]
//        public object DestroyAction { get; set; }

//        [JsonProperty("distance_per_frame")]
//        public object DistancePerFrame { get; set; }

//        [JsonProperty("follows_player")]
//        public object FollowsPlayer { get; set; }

//        [JsonProperty("friction")]
//        public object Friction { get; set; }

//        [JsonProperty("idle")]
//        public object Idle { get; set; }

//        [JsonProperty("in_motion")]
//        public object InMotion { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("range_from_player")]
//        public object RangeFromPlayer { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("shadow_idle")]
//        public object ShadowIdle { get; set; }

//        [JsonProperty("shadow_in_motion")]
//        public object ShadowInMotion { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("time_to_live")]
//        public object TimeToLive { get; set; }

//    }

//    [JsonObject("construction-robot", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ConstructionRobot : Robot
//    {

//        [JsonProperty("cargo_centered")]
//        public object CargoCentered { get; set; }

//        [JsonProperty("construction_vector")]
//        public object ConstructionVector { get; set; }

//        [JsonProperty("energy_per_move")]
//        public object EnergyPerMove { get; set; }

//        [JsonProperty("energy_per_tick")]
//        public object EnergyPerTick { get; set; }

//        [JsonProperty("idle")]
//        public object Idle { get; set; }

//        [JsonProperty("in_motion")]
//        public object InMotion { get; set; }

//        [JsonProperty("max_energy")]
//        public object MaxEnergy { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("max_payload_size")]
//        public object MaxPayloadSize { get; set; }

//        [JsonProperty("max_to_charge")]
//        public object MaxToCharge { get; set; }

//        [JsonProperty("min_to_charge")]
//        public object MinToCharge { get; set; }

//        [JsonProperty("repair_pack")]
//        public object RepairPack { get; set; }

//        [JsonProperty("shadow_idle")]
//        public object ShadowIdle { get; set; }

//        [JsonProperty("shadow_in_motion")]
//        public object ShadowInMotion { get; set; }

//        [JsonProperty("shadow_working")]
//        public object ShadowWorking { get; set; }

//        [JsonProperty("smoke")]
//        public object Smoke { get; set; }

//        [JsonProperty("sparks")]
//        public object Sparks { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("speed_multiplier_when_out_of_energy")]
//        public object SpeedMultiplierWhenOutOfEnergy { get; set; }

//        [JsonProperty("transfer_distance")]
//        public object TransferDistance { get; set; }

//        [JsonProperty("working")]
//        public object Working { get; set; }

//        [JsonProperty("working_light")]
//        public object WorkingLight { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//    }

//    [JsonObject("logistic-robot", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class LogisticRobot : Robot
//    {

//        [JsonProperty("cargo_centered")]
//        public object CargoCentered { get; set; }

//        [JsonProperty("energy_per_move")]
//        public object EnergyPerMove { get; set; }

//        [JsonProperty("energy_per_tick")]
//        public object EnergyPerTick { get; set; }

//        [JsonProperty("idle")]
//        public object Idle { get; set; }

//        [JsonProperty("idle_with_cargo")]
//        public object IdleWithCargo { get; set; }

//        [JsonProperty("in_motion")]
//        public object InMotion { get; set; }

//        [JsonProperty("in_motion_with_cargo")]
//        public object InMotionWithCargo { get; set; }

//        [JsonProperty("max_energy")]
//        public object MaxEnergy { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("max_payload_size")]
//        public object MaxPayloadSize { get; set; }

//        [JsonProperty("max_to_charge")]
//        public object MaxToCharge { get; set; }

//        [JsonProperty("min_to_charge")]
//        public object MinToCharge { get; set; }

//        [JsonProperty("shadow_idle")]
//        public object ShadowIdle { get; set; }

//        [JsonProperty("shadow_idle_with_cargo")]
//        public object ShadowIdleWithCargo { get; set; }

//        [JsonProperty("shadow_in_motion")]
//        public object ShadowInMotion { get; set; }

//        [JsonProperty("shadow_in_motion_with_cargo")]
//        public object ShadowInMotionWithCargo { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("speed_multiplier_when_out_of_energy")]
//        public object SpeedMultiplierWhenOutOfEnergy { get; set; }

//        [JsonProperty("transfer_distance")]
//        public object TransferDistance { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//    }

//    [JsonObject("rocket-defense", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RocketDefense : EntityWithHealth
//    {

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//    }

//    [JsonObject("solar-panel", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class SolarPanel : EntityWithHealth
//    {

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("picture")]
//        public object Picture { get; set; }

//        [JsonProperty("production")]
//        public object Production { get; set; }

//    }

//    [JsonObject("splitter", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Splitter : EntityWithHealth
//    {

//        [JsonProperty("animation_speed_coefficient")]
//        public object AnimationSpeedCoefficient { get; set; }

//        [JsonProperty("belt_horizontal")]
//        public object BeltHorizontal { get; set; }

//        [JsonProperty("belt_vertical")]
//        public object BeltVertical { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("ending_bottom")]
//        public object EndingBottom { get; set; }

//        [JsonProperty("ending_patch")]
//        public object EndingPatch { get; set; }

//        [JsonProperty("ending_side")]
//        public object EndingSide { get; set; }

//        [JsonProperty("ending_top")]
//        public object EndingTop { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("starting_bottom")]
//        public object StartingBottom { get; set; }

//        [JsonProperty("starting_side")]
//        public object StartingSide { get; set; }

//        [JsonProperty("starting_top")]
//        public object StartingTop { get; set; }

//        [JsonProperty("structure")]
//        public object Structure { get; set; }

//        [JsonProperty("structure_animation_movement_cooldown")]
//        public object StructureAnimationMovementCooldown { get; set; }

//        [JsonProperty("structure_animation_speed_coefficient")]
//        public object StructureAnimationSpeedCoefficient { get; set; }

//    }

//    [JsonObject("train-stop", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class TrainStop : EntityWithHealth
//    {

//        [JsonProperty("animation_ticks_per_frame")]
//        public object AnimationTicksPerFrame { get; set; }

//        [JsonProperty("animations")]
//        public object Animations { get; set; }

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_points")]
//        public object CircuitWireConnectionPoints { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("color")]
//        public object Color { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("drawing_boxes")]
//        public object DrawingBoxes { get; set; }

//        [JsonProperty("light1")]
//        public object Light1 { get; set; }

//        [JsonProperty("light2")]
//        public object Light2 { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("rail_overlay_animations")]
//        public object RailOverlayAnimations { get; set; }

//        [JsonProperty("top_animations")]
//        public object TopAnimations { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("Prototype/TrainUnit", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class TrainUnit : EntityWithHealth
//    {

//    }

//    [JsonObject("cargo-wagon", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class CargoWagon : TrainUnit
//    {

//        [JsonProperty("air_resistance")]
//        public object AirResistance { get; set; }

//        [JsonProperty("back_light")]
//        public object BackLight { get; set; }

//        [JsonProperty("braking_force")]
//        public object BrakingForce { get; set; }

//        [JsonProperty("close_sound")]
//        public object CloseSound { get; set; }

//        [JsonProperty("color")]
//        public object Color { get; set; }

//        [JsonProperty("connection_distance")]
//        public object ConnectionDistance { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("crash_trigger")]
//        public object CrashTrigger { get; set; }

//        [JsonProperty("drive_over_tie_trigger")]
//        public object DriveOverTieTrigger { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("energy_per_hit_point")]
//        public object EnergyPerHitPoint { get; set; }

//        [JsonProperty("friction_force")]
//        public object FrictionForce { get; set; }

//        [JsonProperty("horizontal_doors")]
//        public object HorizontalDoors { get; set; }

//        [JsonProperty("inventory_size")]
//        public object InventorySize { get; set; }

//        [JsonProperty("joint_distance")]
//        public object JointDistance { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("max_speed")]
//        public object MaxSpeed { get; set; }

//        [JsonProperty("mined_sound")]
//        public object MinedSound { get; set; }

//        [JsonProperty("open_sound")]
//        public object OpenSound { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("rail_category")]
//        public object RailCategory { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("sound_minimum_speed")]
//        public object SoundMinimumSpeed { get; set; }

//        [JsonProperty("stand_by_light")]
//        public object StandByLight { get; set; }

//        [JsonProperty("tie_distance")]
//        public object TieDistance { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("vertical_doors")]
//        public object VerticalDoors { get; set; }

//        [JsonProperty("wheels")]
//        public object Wheels { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("locomotive", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Locomotive : TrainUnit
//    {

//        [JsonProperty("air_resistance")]
//        public object AirResistance { get; set; }

//        [JsonProperty("back_light")]
//        public object BackLight { get; set; }

//        [JsonProperty("braking_force")]
//        public object BrakingForce { get; set; }

//        [JsonProperty("close_sound")]
//        public object CloseSound { get; set; }

//        [JsonProperty("color")]
//        public object Color { get; set; }

//        [JsonProperty("connection_distance")]
//        public object ConnectionDistance { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("crash_trigger")]
//        public object CrashTrigger { get; set; }

//        [JsonProperty("drive_over_tie_trigger")]
//        public object DriveOverTieTrigger { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("energy_per_hit_point")]
//        public object EnergyPerHitPoint { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("friction_force")]
//        public object FrictionForce { get; set; }

//        [JsonProperty("front_light")]
//        public object FrontLight { get; set; }

//        [JsonProperty("joint_distance")]
//        public object JointDistance { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("max_power")]
//        public object MaxPower { get; set; }

//        [JsonProperty("max_speed")]
//        public object MaxSpeed { get; set; }

//        [JsonProperty("mined_sound")]
//        public object MinedSound { get; set; }

//        [JsonProperty("open_sound")]
//        public object OpenSound { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("rail_category")]
//        public object RailCategory { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("reversing_power_modifier")]
//        public object ReversingPowerModifier { get; set; }

//        [JsonProperty("sound_minimum_speed")]
//        public object SoundMinimumSpeed { get; set; }

//        [JsonProperty("stand_by_light")]
//        public object StandByLight { get; set; }

//        [JsonProperty("stop_trigger")]
//        public object StopTrigger { get; set; }

//        [JsonProperty("tie_distance")]
//        public object TieDistance { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("wheels")]
//        public object Wheels { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("transport-belt", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class TransportBelt : EntityWithHealth
//    {

//        [JsonProperty("animation_speed_coefficient")]
//        public object AnimationSpeedCoefficient { get; set; }

//        [JsonProperty("animations")]
//        public object Animations { get; set; }

//        [JsonProperty("belt_horizontal")]
//        public object BeltHorizontal { get; set; }

//        [JsonProperty("belt_vertical")]
//        public object BeltVertical { get; set; }

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_point")]
//        public object CircuitWireConnectionPoint { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("connector_frame_sprites")]
//        public object ConnectorFrameSprites { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("ending_bottom")]
//        public object EndingBottom { get; set; }

//        [JsonProperty("ending_patch")]
//        public object EndingPatch { get; set; }

//        [JsonProperty("ending_side")]
//        public object EndingSide { get; set; }

//        [JsonProperty("ending_top")]
//        public object EndingTop { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("starting_bottom")]
//        public object StartingBottom { get; set; }

//        [JsonProperty("starting_side")]
//        public object StartingSide { get; set; }

//        [JsonProperty("starting_top")]
//        public object StartingTop { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("transport-belt-to-ground", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class TransportBeltToGround : EntityWithHealth
//    {

//    }

//    [JsonObject("tree", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Tree : EntityWithHealth
//    {

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("colors")]
//        public object Colors { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("darkness_of_burnt_tree")]
//        public object DarknessOfBurntTree { get; set; }

//        [JsonProperty("remains_when_mined")]
//        public object RemainsWhenMined { get; set; }

//        [JsonProperty("variations")]
//        public object Variations { get; set; }

//    }

//    [JsonObject("turret", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Turret : EntityWithHealth
//    {

//        [JsonProperty("attack_parameters")]
//        public object AttackParameters { get; set; }

//        [JsonProperty("build_base_evolution_requirement")]
//        public object BuildBaseEvolutionRequirement { get; set; }

//        [JsonProperty("call_for_help_radius")]
//        public object CallForHelpRadius { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("dying_sound")]
//        public object DyingSound { get; set; }

//        [JsonProperty("ending_attack_animation")]
//        public object EndingAttackAnimation { get; set; }

//        [JsonProperty("ending_attack_speed")]
//        public object EndingAttackSpeed { get; set; }

//        [JsonProperty("folded_animation")]
//        public object FoldedAnimation { get; set; }

//        [JsonProperty("folded_speed")]
//        public object FoldedSpeed { get; set; }

//        [JsonProperty("folding_animation")]
//        public object FoldingAnimation { get; set; }

//        [JsonProperty("folding_speed")]
//        public object FoldingSpeed { get; set; }

//        [JsonProperty("healing_per_tick")]
//        public object HealingPerTick { get; set; }

//        [JsonProperty("inventory_size")]
//        public object InventorySize { get; set; }

//        [JsonProperty("loot")]
//        public object Loot { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("prepare_range")]
//        public object PrepareRange { get; set; }

//        [JsonProperty("prepared_animation")]
//        public object PreparedAnimation { get; set; }

//        [JsonProperty("prepared_speed")]
//        public object PreparedSpeed { get; set; }

//        [JsonProperty("preparing_animation")]
//        public object PreparingAnimation { get; set; }

//        [JsonProperty("preparing_speed")]
//        public object PreparingSpeed { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("rotation_speed")]
//        public object RotationSpeed { get; set; }

//        [JsonProperty("shooting_cursor_size")]
//        public object ShootingCursorSize { get; set; }

//        [JsonProperty("starting_attack_animation")]
//        public object StartingAttackAnimation { get; set; }

//        [JsonProperty("starting_attack_sound")]
//        public object StartingAttackSound { get; set; }

//        [JsonProperty("starting_attack_speed")]
//        public object StartingAttackSpeed { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("ammo-turret", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class AmmoTurret : Turret
//    {

//        [JsonProperty("attacking_animation")]
//        public object AttackingAnimation { get; set; }

//        [JsonProperty("attacking_speed")]
//        public object AttackingSpeed { get; set; }

//        [JsonProperty("automated_ammo_count")]
//        public object AutomatedAmmoCount { get; set; }

//        [JsonProperty("base_picture")]
//        public object BasePicture { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("electric-turret", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ElectricTurret : Turret
//    {

//        [JsonProperty("base_picture")]
//        public object BasePicture { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("unit", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Unit : EntityWithHealth
//    {

//        [JsonProperty("attack_parameters")]
//        public object AttackParameters { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("distance_per_frame")]
//        public object DistancePerFrame { get; set; }

//        [JsonProperty("distraction_cooldown")]
//        public object DistractionCooldown { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("dying_sound")]
//        public object DyingSound { get; set; }

//        [JsonProperty("healing_per_tick")]
//        public object HealingPerTick { get; set; }

//        [JsonProperty("loot")]
//        public object Loot { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("movement_speed")]
//        public object MovementSpeed { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("pollution_to_join_attack")]
//        public object PollutionToJoinAttack { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("run_animation")]
//        public object RunAnimation { get; set; }

//        [JsonProperty("spawning_time_modifier")]
//        public object SpawningTimeModifier { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("vision_distance")]
//        public object VisionDistance { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("unit-spawner", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class UnitSpawner : EntityWithHealth
//    {

//        [JsonProperty("animations")]
//        public object Animations { get; set; }

//        [JsonProperty("call_for_help_radius")]
//        public object CallForHelpRadius { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("dying_sound")]
//        public object DyingSound { get; set; }

//        [JsonProperty("healing_per_tick")]
//        public object HealingPerTick { get; set; }

//        [JsonProperty("loot")]
//        public object Loot { get; set; }

//        [JsonProperty("max_count_of_owned_units")]
//        public object MaxCountOfOwnedUnits { get; set; }

//        [JsonProperty("max_friends_around_to_spawn")]
//        public object MaxFriendsAroundToSpawn { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("max_richness_for_spawn_shift")]
//        public object MaxRichnessForSpawnShift { get; set; }

//        [JsonProperty("max_spawn_shift")]
//        public object MaxSpawnShift { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("pollution_absorbtion_absolute")]
//        public object PollutionAbsorbtionAbsolute { get; set; }

//        [JsonProperty("pollution_absorbtion_proportional")]
//        public object PollutionAbsorbtionProportional { get; set; }

//        [JsonProperty("pollution_to_enhance_spawning")]
//        public object PollutionToEnhanceSpawning { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("result_units")]
//        public object ResultUnits { get; set; }

//        [JsonProperty("spawning_cooldown")]
//        public object SpawningCooldown { get; set; }

//        [JsonProperty("spawning_radius")]
//        public object SpawningRadius { get; set; }

//        [JsonProperty("spawning_spacing")]
//        public object SpawningSpacing { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("wall", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Wall : EntityWithHealth
//    {

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_point")]
//        public object CircuitWireConnectionPoint { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("connected_gate_visualization")]
//        public object ConnectedGateVisualization { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("default_output_signal")]
//        public object DefaultOutputSignal { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("mined_sound")]
//        public object MinedSound { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("repair_sound")]
//        public object RepairSound { get; set; }

//        [JsonProperty("repair_speed_modifier")]
//        public object RepairSpeedModifier { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("wall_diode_green")]
//        public object WallDiodeGreen { get; set; }

//        [JsonProperty("wall_diode_green_light")]
//        public object WallDiodeGreenLight { get; set; }

//        [JsonProperty("wall_diode_red")]
//        public object WallDiodeRed { get; set; }

//        [JsonProperty("wall_diode_red_light")]
//        public object WallDiodeRedLight { get; set; }

//    }

//    [JsonObject("flying-text", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class FlyingText : Entity
//    {

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("time_to_live")]
//        public object TimeToLive { get; set; }

//    }

//    [JsonObject("ghost", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Ghost : Entity
//    {

//    }

//    [JsonObject("item-entity", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ItemEntity : Entity
//    {

//    }

//    [JsonObject("land-mine", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class LandMine : Entity
//    {

//        [JsonProperty("action")]
//        public object Action { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("picture_safe")]
//        public object PictureSafe { get; set; }

//        [JsonProperty("picture_set")]
//        public object PictureSet { get; set; }

//        [JsonProperty("trigger_radius")]
//        public object TriggerRadius { get; set; }

//    }

//    [JsonObject("particle", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Particle : Entity
//    {

//        [JsonProperty("life_time")]
//        public object LifeTime { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("shadows")]
//        public object Shadows { get; set; }

//        [JsonProperty("movement_modifier_when_on_ground")]
//        public object MovementModifierWhenOnGround { get; set; }

//        [JsonProperty("ended_in_water_trigger_effect")]
//        public object EndedInWaterTriggerEffect { get; set; }

//        [JsonProperty("regular_trigger_effect")]
//        public object RegularTriggerEffect { get; set; }

//        [JsonProperty("regular_trigger_effect_frequency")]
//        public object RegularTriggerEffectFrequency { get; set; }

//    }

//    [JsonObject("projectile", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Projectile : Entity
//    {

//        [JsonProperty("acceleration")]
//        public object Acceleration { get; set; }

//        [JsonProperty("action")]
//        public object Action { get; set; }

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("rotatable")]
//        public object Rotatable { get; set; }

//        [JsonProperty("shadow")]
//        public object Shadow { get; set; }

//        [JsonProperty("light")]
//        public object Light { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("direction_only")]
//        public object DirectionOnly { get; set; }

//        [JsonProperty("final_action")]
//        public object FinalAction { get; set; }

//        [JsonProperty("piercing_damage")]
//        public object PiercingDamage { get; set; }

//        [JsonProperty("smoke")]
//        public object Smoke { get; set; }

//    }

//    [JsonObject("rail-remnants", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RailRemnants : Entity
//    {

//        [JsonProperty("bending_type")]
//        public object BendingType { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("selectable_in_game")]
//        public object SelectableInGame { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("time_before_removed")]
//        public object TimeBeforeRemoved { get; set; }

//        [JsonProperty("time_before_shading_off")]
//        public object TimeBeforeShadingOff { get; set; }

//    }

//    [JsonObject("resource", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Resource : Entity
//    {

//        [JsonProperty("map_color")]
//        public object MapColor { get; set; }

//        [JsonProperty("minimum")]
//        public object Minimum { get; set; }

//        [JsonProperty("normal")]
//        public object Normal { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("stage_counts")]
//        public object StageCounts { get; set; }

//        [JsonProperty("stages")]
//        public object Stages { get; set; }

//        [JsonProperty("category")]
//        public object Category { get; set; }

//        [JsonProperty("infinite")]
//        public object Infinite { get; set; }

//        [JsonProperty("map_grid")]
//        public object MapGrid { get; set; }

//    }

//    [JsonObject("smoke", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Smoke : Entity
//    {

//        [JsonProperty("affected_by_wind")]
//        public object AffectedByWind { get; set; }

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("color")]
//        public object Color { get; set; }

//        [JsonProperty("cyclic")]
//        public object Cyclic { get; set; }

//        [JsonProperty("duration")]
//        public object Duration { get; set; }

//        [JsonProperty("end_scale")]
//        public object EndScale { get; set; }

//        [JsonProperty("fade_away_duration")]
//        public object FadeAwayDuration { get; set; }

//        [JsonProperty("spread_duration")]
//        public object SpreadDuration { get; set; }

//        [JsonProperty("start_scale")]
//        public object StartScale { get; set; }

//        [JsonProperty("fade_in_duration")]
//        public object FadeInDuration { get; set; }

//        [JsonProperty("glow_animation")]
//        public object GlowAnimation { get; set; }

//        [JsonProperty("glow_fade_away_duration")]
//        public object GlowFadeAwayDuration { get; set; }

//        [JsonProperty("movement_slow_down_factor")]
//        public object MovementSlowDownFactor { get; set; }

//        [JsonProperty("render_layer")]
//        public object RenderLayer { get; set; }

//        [JsonProperty("show_when_smoke_off")]
//        public object ShowWhenSmokeOff { get; set; }

//    }

//    [JsonObject("sticker", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Sticker : Entity
//    {

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("damage_per_tick")]
//        public object DamagePerTick { get; set; }

//        [JsonProperty("duration_in_ticks")]
//        public object DurationInTicks { get; set; }

//        [JsonProperty("fire_spread_cooldown")]
//        public object FireSpreadCooldown { get; set; }

//        [JsonProperty("fire_spread_radius")]
//        public object FireSpreadRadius { get; set; }

//        [JsonProperty("spread_fire_entity")]
//        public object SpreadFireEntity { get; set; }

//        [JsonProperty("target_movement_modifier")]
//        public object TargetMovementModifier { get; set; }

//    }

//    public partial class Item
//    {

//        [JsonProperty("default_request_amount")]
//        public object DefaultRequestAmount { get; set; }

//        [JsonProperty("placed_as_equipment_result")]
//        public object PlacedAsEquipmentResult { get; set; }

//        [JsonProperty("dark_background_icon")]
//        public object DarkBackgroundIcon { get; set; }

//        [JsonProperty("place_as_tile")]
//        public object PlaceAsTile { get; set; }

//        [JsonProperty("damage_radius")]
//        public object DamageRadius { get; set; }

//        [JsonProperty("trigger_radius")]
//        public object TriggerRadius { get; set; }

//    }

//    [JsonObject("ammo", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Ammo : Item
//    {

//        [JsonProperty("ammo_type")]
//        public object AmmoType { get; set; }

//        [JsonProperty("magazine_size")]
//        public object MagazineSize { get; set; }

//    }

//    [JsonObject("armor", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Armor : Item
//    {

//        [JsonProperty("durability")]
//        public object Durability { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("equipment_grid")]
//        public object EquipmentGrid { get; set; }

//        [JsonProperty("inventory_size_bonus")]
//        public object InventorySizeBonus { get; set; }

//    }

//    [JsonObject("capsule", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Capsule : Item
//    {

//        [JsonProperty("capsule_action")]
//        public object CapsuleAction { get; set; }

//    }

//    [JsonObject("Prototype/Equipment", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Equipment : Item
//    {

//    }

//    [JsonObject("night-vision-equipment", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class NightVisionEquipment : Equipment
//    {

//        [JsonProperty("energy_input")]
//        public object EnergyInput { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("shape")]
//        public object Shape { get; set; }

//        [JsonProperty("sprite")]
//        public object Sprite { get; set; }

//        [JsonProperty("tint")]
//        public object Tint { get; set; }

//    }

//    [JsonObject("energy-shield-equipment", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class EnergyShieldEquipment : Equipment
//    {

//        [JsonProperty("energy_per_shield")]
//        public object EnergyPerShield { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("max_shield_value")]
//        public object MaxShieldValue { get; set; }

//        [JsonProperty("shape")]
//        public object Shape { get; set; }

//        [JsonProperty("sprite")]
//        public object Sprite { get; set; }

//    }

//    [JsonObject("battery-equipment", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class BatteryEquipment : Equipment
//    {

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("shape")]
//        public object Shape { get; set; }

//        [JsonProperty("sprite")]
//        public object Sprite { get; set; }

//    }

//    [JsonObject("solar-panel-equipment", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class SolarPanelEquipment : Equipment
//    {

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("power")]
//        public object Power { get; set; }

//        [JsonProperty("shape")]
//        public object Shape { get; set; }

//        [JsonProperty("sprite")]
//        public object Sprite { get; set; }

//    }

//    [JsonObject("generator-equipment", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class GeneratorEquipment : Equipment
//    {

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("power")]
//        public object Power { get; set; }

//        [JsonProperty("shape")]
//        public object Shape { get; set; }

//        [JsonProperty("sprite")]
//        public object Sprite { get; set; }

//    }

//    [JsonObject("active-defense-equipment", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ActiveDefenseEquipment : Equipment
//    {

//        [JsonProperty("ability_icon")]
//        public object AbilityIcon { get; set; }

//        [JsonProperty("attack_parameters")]
//        public object AttackParameters { get; set; }

//        [JsonProperty("automatic")]
//        public object Automatic { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("shape")]
//        public object Shape { get; set; }

//        [JsonProperty("sprite")]
//        public object Sprite { get; set; }

//    }

//    [JsonObject("movement-bonus-equipment", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class MovementBonusEquipment : Equipment
//    {

//        [JsonProperty("energy_consumption")]
//        public object EnergyConsumption { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("movement_bonus")]
//        public object MovementBonus { get; set; }

//        [JsonProperty("shape")]
//        public object Shape { get; set; }

//        [JsonProperty("sprite")]
//        public object Sprite { get; set; }

//    }

//    [JsonObject("gun", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Gun : Item
//    {

//        [JsonProperty("attack_parameters")]
//        public object AttackParameters { get; set; }

//    }

//    [JsonObject("mining-tool", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class MiningTool : Item
//    {

//        [JsonProperty("action")]
//        public object Action { get; set; }

//        [JsonProperty("durability")]
//        public object Durability { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//    }

//    [JsonObject("module", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Module : Item
//    {

//        [JsonProperty("category")]
//        public object Category { get; set; }

//        [JsonProperty("effect")]
//        public object Effect { get; set; }

//        [JsonProperty("tier")]
//        public object Tier { get; set; }

//        [JsonProperty("limitation")]
//        public object Limitation { get; set; }

//        [JsonProperty("limitation_message_key")]
//        public object LimitationMessageKey { get; set; }

//    }

//    public partial class ItemGroup
//    {

//        [JsonProperty("inventory_order")]
//        public object InventoryOrder { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//    }

//    [JsonObject("map-settings", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class MapSettings : TypedNamedBase
//    {

//        [JsonProperty("attack")]
//        public object Attack { get; set; }

//        [JsonProperty("enemy_evolution")]
//        public object EnemyEvolution { get; set; }

//        [JsonProperty("enemy_expansion")]
//        public object EnemyExpansion { get; set; }

//        [JsonProperty("max_failed_behavior_count")]
//        public object MaxFailedBehaviorCount { get; set; }

//        [JsonProperty("path_finder")]
//        public object PathFinder { get; set; }

//        [JsonProperty("pollution")]
//        public object Pollution { get; set; }

//        [JsonProperty("steering")]
//        public object Steering { get; set; }

//        [JsonProperty("unit_group")]
//        public object UnitGroup { get; set; }

//    }

//    [JsonObject("noise-layer", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class NoiseLayer : TypedNamedBase
//    {

//    }

//    [JsonObject("rail-category", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RailCategory : TypedNamedBase
//    {

//    }

//    public partial class Recipe
//    {

//        [JsonProperty("ingredients")]
//        public object Ingredients { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("results")]
//        public object Results { get; set; }

//        [JsonProperty("main_product")]
//        public object MainProduct { get; set; }

//        [JsonProperty("requester_paste_multiplier")]
//        public object RequesterPasteMultiplier { get; set; }

//        [JsonProperty("hidden")]
//        public object Hidden { get; set; }

//    }

//    public partial class RecipeCategory
//    {

//    }

//    public partial class Technology
//    {

//        [JsonProperty("unit")]
//        public object Unit { get; set; }

//        [JsonProperty("upgrade")]
//        public object Upgrade { get; set; }

//        [JsonProperty("icon_size")]
//        public object IconSize { get; set; }

//    }

//    [JsonObject("tile", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Tile : TypedNamedBase
//    {

//        [JsonProperty("ageing")]
//        public object Ageing { get; set; }

//        [JsonProperty("collision_mask")]
//        public object CollisionMask { get; set; }

//        [JsonProperty("decorative_removal_probability")]
//        public object DecorativeRemovalProbability { get; set; }

//        [JsonProperty("layer")]
//        public object Layer { get; set; }

//        [JsonProperty("map_color")]
//        public object MapColor { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("mined_sound")]
//        public object MinedSound { get; set; }

//        [JsonProperty("needs_correction")]
//        public object NeedsCorrection { get; set; }

//        [JsonProperty("variants")]
//        public object Variants { get; set; }

//        [JsonProperty("vehicle_friction_modifier")]
//        public object VehicleFrictionModifier { get; set; }

//        [JsonProperty("walking_sound")]
//        public object WalkingSound { get; set; }

//        [JsonProperty("walking_speed_modifier")]
//        public object WalkingSpeedModifier { get; set; }

//        [JsonProperty("allowed_neighbors")]
//        public object AllowedNeighbors { get; set; }

//        [JsonProperty("autoplace")]
//        public object Autoplace { get; set; }

//        [JsonProperty("can_be_part_of_blueprint")]
//        public object CanBePartOfBlueprint { get; set; }

//        [JsonProperty("next_direction")]
//        public object NextDirection { get; set; }

//    }

//    [JsonObject("achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Achievement : TypedNamedBase
//    {

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//    }

//    [JsonObject("ambient-sound", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class AmbientSound : TypedNamedBase
//    {

//        [JsonProperty("sound")]
//        public object Sound { get; set; }

//        [JsonProperty("track_type")]
//        public object TrackType { get; set; }

//    }

//    [JsonObject("arithmetic-combinator", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ArithmeticCombinator : TypedNamedBase
//    {

//        [JsonProperty("active_energy_usage")]
//        public object ActiveEnergyUsage { get; set; }

//        [JsonProperty("activity_led_light")]
//        public object ActivityLedLight { get; set; }

//        [JsonProperty("activity_led_light_offsets")]
//        public object ActivityLedLightOffsets { get; set; }

//        [JsonProperty("activity_led_sprites")]
//        public object ActivityLedSprites { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("divide_symbol_sprites")]
//        public object DivideSymbolSprites { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("input_connection_bounding_box")]
//        public object InputConnectionBoundingBox { get; set; }

//        [JsonProperty("input_connection_points")]
//        public object InputConnectionPoints { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("minus_symbol_sprites")]
//        public object MinusSymbolSprites { get; set; }

//        [JsonProperty("multiply_symbol_sprites")]
//        public object MultiplySymbolSprites { get; set; }

//        [JsonProperty("output_connection_bounding_box")]
//        public object OutputConnectionBoundingBox { get; set; }

//        [JsonProperty("output_connection_points")]
//        public object OutputConnectionPoints { get; set; }

//        [JsonProperty("plus_symbol_sprites")]
//        public object PlusSymbolSprites { get; set; }

//        [JsonProperty("screen_light")]
//        public object ScreenLight { get; set; }

//        [JsonProperty("screen_light_offsets")]
//        public object ScreenLightOffsets { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("sprites")]
//        public object Sprites { get; set; }

//    }

//    [JsonObject("beam", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Beam : TypedNamedBase
//    {

//        [JsonProperty("action")]
//        public object Action { get; set; }

//        [JsonProperty("body")]
//        public object Body { get; set; }

//        [JsonProperty("damage_interval")]
//        public object DamageInterval { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("head")]
//        public object Head { get; set; }

//        [JsonProperty("tail")]
//        public object Tail { get; set; }

//        [JsonProperty("width")]
//        public object Width { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("blueprint", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Blueprint : TypedNamedBase
//    {

//        [JsonProperty("alt_selection_color")]
//        public object AltSelectionColor { get; set; }

//        [JsonProperty("alt_selection_cursor_box_type")]
//        public object AltSelectionCursorBoxType { get; set; }

//        [JsonProperty("alt_selection_mode")]
//        public object AltSelectionMode { get; set; }

//        [JsonProperty("draw_label_for_cursor_render")]
//        public object DrawLabelForCursorRender { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("item_to_clear")]
//        public object ItemToClear { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("selection_color")]
//        public object SelectionColor { get; set; }

//        [JsonProperty("selection_cursor_box_type")]
//        public object SelectionCursorBoxType { get; set; }

//        [JsonProperty("selection_mode")]
//        public object SelectionMode { get; set; }

//        [JsonProperty("stack_size")]
//        public object StackSize { get; set; }

//        [JsonProperty("stackable")]
//        public object Stackable { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("blueprint-book", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class BlueprintBook : TypedNamedBase
//    {

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("inventory_size")]
//        public object InventorySize { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("stack_size")]
//        public object StackSize { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("build-entity-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class BuildEntityAchievement : TypedNamedBase
//    {

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("to_build")]
//        public object ToBuild { get; set; }

//        [JsonProperty("until_second")]
//        public object UntilSecond { get; set; }

//    }

//    [JsonObject("combat-robot-count", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class CombatRobotCount : TypedNamedBase
//    {

//        [JsonProperty("count")]
//        public object Count { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("steam_stats_name")]
//        public object SteamStatsName { get; set; }

//    }

//    [JsonObject("constant-combinator", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ConstantCombinator : TypedNamedBase
//    {

//        [JsonProperty("activity_led_light")]
//        public object ActivityLedLight { get; set; }

//        [JsonProperty("activity_led_light_offsets")]
//        public object ActivityLedLightOffsets { get; set; }

//        [JsonProperty("activity_led_sprites")]
//        public object ActivityLedSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_points")]
//        public object CircuitWireConnectionPoints { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("item_slot_count")]
//        public object ItemSlotCount { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("sprites")]
//        public object Sprites { get; set; }

//    }

//    [JsonObject("construct-with-robots-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ConstructWithRobotsAchievement : TypedNamedBase
//    {

//        [JsonProperty("amount")]
//        public object Amount { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("limited_to_one_game")]
//        public object LimitedToOneGame { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("steam_stats_name")]
//        public object SteamStatsName { get; set; }

//        [JsonProperty("more_than_manually")]
//        public object MoreThanManually { get; set; }

//    }

//    [JsonObject("curved-rail", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class CurvedRail : TypedNamedBase
//    {

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("placeable_by")]
//        public object PlaceableBy { get; set; }

//        [JsonProperty("rail_category")]
//        public object RailCategory { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("secondary_collision_box")]
//        public object SecondaryCollisionBox { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//    }

//    [JsonObject("custom-input", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class CustomInput : TypedNamedBase
//    {

//        [JsonProperty("consuming")]
//        public object Consuming { get; set; }

//        [JsonProperty("key_sequence")]
//        public object KeySequence { get; set; }

//    }

//    [JsonObject("decider-combinator", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class DeciderCombinator : TypedNamedBase
//    {

//        [JsonProperty("active_energy_usage")]
//        public object ActiveEnergyUsage { get; set; }

//        [JsonProperty("activity_led_light")]
//        public object ActivityLedLight { get; set; }

//        [JsonProperty("activity_led_light_offsets")]
//        public object ActivityLedLightOffsets { get; set; }

//        [JsonProperty("activity_led_sprites")]
//        public object ActivityLedSprites { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("equal_symbol_sprites")]
//        public object EqualSymbolSprites { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("greater_symbol_sprites")]
//        public object GreaterSymbolSprites { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("input_connection_bounding_box")]
//        public object InputConnectionBoundingBox { get; set; }

//        [JsonProperty("input_connection_points")]
//        public object InputConnectionPoints { get; set; }

//        [JsonProperty("less_symbol_sprites")]
//        public object LessSymbolSprites { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("output_connection_bounding_box")]
//        public object OutputConnectionBoundingBox { get; set; }

//        [JsonProperty("output_connection_points")]
//        public object OutputConnectionPoints { get; set; }

//        [JsonProperty("screen_light")]
//        public object ScreenLight { get; set; }

//        [JsonProperty("screen_light_offsets")]
//        public object ScreenLightOffsets { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("sprites")]
//        public object Sprites { get; set; }

//    }

//    [JsonObject("deconstructible-tile-proxy", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class DeconstructibleTileProxy : TypedNamedBase
//    {

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//    }

//    [JsonObject("deconstruction-item", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class DeconstructionItem : TypedNamedBase
//    {

//        [JsonProperty("alt_selection_color")]
//        public object AltSelectionColor { get; set; }

//        [JsonProperty("alt_selection_cursor_box_type")]
//        public object AltSelectionCursorBoxType { get; set; }

//        [JsonProperty("alt_selection_mode")]
//        public object AltSelectionMode { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("selection_color")]
//        public object SelectionColor { get; set; }

//        [JsonProperty("selection_cursor_box_type")]
//        public object SelectionCursorBoxType { get; set; }

//        [JsonProperty("selection_mode")]
//        public object SelectionMode { get; set; }

//        [JsonProperty("stack_size")]
//        public object StackSize { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("deconstruct-with-robots-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class DeconstructWithRobotsAchievement : TypedNamedBase
//    {

//        [JsonProperty("amount")]
//        public object Amount { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("steam_stats_name")]
//        public object SteamStatsName { get; set; }

//    }

//    [JsonObject("deliver-by-robots-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class DeliverByRobotsAchievement : TypedNamedBase
//    {

//        [JsonProperty("amount")]
//        public object Amount { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("steam_stats_name")]
//        public object SteamStatsName { get; set; }

//    }

//    [JsonObject("dont-build-entity-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class DontBuildEntityAchievement : TypedNamedBase
//    {

//        [JsonProperty("dont_build")]
//        public object DontBuild { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("allowed_in_peaceful_mode")]
//        public object AllowedInPeacefulMode { get; set; }

//    }

//    [JsonObject("dont-craft-manually-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class DontCraftManuallyAchievement : TypedNamedBase
//    {

//        [JsonProperty("amount")]
//        public object Amount { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//    }

//    [JsonObject("dont-use-entity-in-energy-production-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class DontUseEntityInEnergyProductionAchievement : TypedNamedBase
//    {

//        [JsonProperty("excluded")]
//        public object Excluded { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("included")]
//        public object Included { get; set; }

//        [JsonProperty("last_hour_only")]
//        public object LastHourOnly { get; set; }

//        [JsonProperty("minimum_energy_produced")]
//        public object MinimumEnergyProduced { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("allowed_in_peaceful_mode")]
//        public object AllowedInPeacefulMode { get; set; }

//    }

//    [JsonObject("entity-ghost", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class EntityGhost : TypedNamedBase
//    {

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//    }

//    [JsonObject("finish-the-game-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class FinishTheGameAchievement : TypedNamedBase
//    {

//        [JsonProperty("allowed_in_peaceful_mode")]
//        public object AllowedInPeacefulMode { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("until_second")]
//        public object UntilSecond { get; set; }

//    }

//    [JsonObject("fire", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Fire : TypedNamedBase
//    {

//        [JsonProperty("add_fuel_cooldown")]
//        public object AddFuelCooldown { get; set; }

//        [JsonProperty("burnt_patch_alpha_default")]
//        public object BurntPatchAlphaDefault { get; set; }

//        [JsonProperty("burnt_patch_alpha_variations")]
//        public object BurntPatchAlphaVariations { get; set; }

//        [JsonProperty("burnt_patch_lifetime")]
//        public object BurntPatchLifetime { get; set; }

//        [JsonProperty("burnt_patch_pictures")]
//        public object BurntPatchPictures { get; set; }

//        [JsonProperty("color")]
//        public object Color { get; set; }

//        [JsonProperty("damage_per_tick")]
//        public object DamagePerTick { get; set; }

//        [JsonProperty("delay_between_initial_flames")]
//        public object DelayBetweenInitialFlames { get; set; }

//        [JsonProperty("duration")]
//        public object Duration { get; set; }

//        [JsonProperty("emissions_per_tick")]
//        public object EmissionsPerTick { get; set; }

//        [JsonProperty("end_scale")]
//        public object EndScale { get; set; }

//        [JsonProperty("fade_away_duration")]
//        public object FadeAwayDuration { get; set; }

//        [JsonProperty("fade_in_duration")]
//        public object FadeInDuration { get; set; }

//        [JsonProperty("fade_out_duration")]
//        public object FadeOutDuration { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("flame_alpha")]
//        public object FlameAlpha { get; set; }

//        [JsonProperty("flame_alpha_deviation")]
//        public object FlameAlphaDeviation { get; set; }

//        [JsonProperty("increase_duration_by")]
//        public object IncreaseDurationBy { get; set; }

//        [JsonProperty("increase_duration_cooldown")]
//        public object IncreaseDurationCooldown { get; set; }

//        [JsonProperty("initial_lifetime")]
//        public object InitialLifetime { get; set; }

//        [JsonProperty("lifetime_increase_by")]
//        public object LifetimeIncreaseBy { get; set; }

//        [JsonProperty("lifetime_increase_cooldown")]
//        public object LifetimeIncreaseCooldown { get; set; }

//        [JsonProperty("light")]
//        public object Light { get; set; }

//        [JsonProperty("maximum_spread_count")]
//        public object MaximumSpreadCount { get; set; }

//        [JsonProperty("on_fuel_added_action")]
//        public object OnFuelAddedAction { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("smoke")]
//        public object Smoke { get; set; }

//        [JsonProperty("smoke_source_pictures")]
//        public object SmokeSourcePictures { get; set; }

//        [JsonProperty("spawn_entity")]
//        public object SpawnEntity { get; set; }

//        [JsonProperty("spread_delay")]
//        public object SpreadDelay { get; set; }

//        [JsonProperty("spread_delay_deviation")]
//        public object SpreadDelayDeviation { get; set; }

//        [JsonProperty("spread_duration")]
//        public object SpreadDuration { get; set; }

//        [JsonProperty("start_scale")]
//        public object StartScale { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//        [JsonProperty("small_tree_fire_pictures")]
//        public object SmallTreeFirePictures { get; set; }

//        [JsonProperty("smoke_fade_in_duration")]
//        public object SmokeFadeInDuration { get; set; }

//        [JsonProperty("smoke_fade_out_duration")]
//        public object SmokeFadeOutDuration { get; set; }

//        [JsonProperty("tree_dying_factor")]
//        public object TreeDyingFactor { get; set; }

//    }

//    [JsonObject("fluid", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Fluid : TypedNamedBase
//    {

//        [JsonProperty("base_color")]
//        public object BaseColor { get; set; }

//        [JsonProperty("default_temperature")]
//        public object DefaultTemperature { get; set; }

//        [JsonProperty("flow_color")]
//        public object FlowColor { get; set; }

//        [JsonProperty("flow_to_energy_ratio")]
//        public object FlowToEnergyRatio { get; set; }

//        [JsonProperty("heat_capacity")]
//        public object HeatCapacity { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_temperature")]
//        public object MaxTemperature { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("pressure_to_speed_ratio")]
//        public object PressureToSpeedRatio { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("fluid-turret", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class FluidTurret : TypedNamedBase
//    {

//        [JsonProperty("activation_buffer_ratio")]
//        public object ActivationBufferRatio { get; set; }

//        [JsonProperty("attack_parameters")]
//        public object AttackParameters { get; set; }

//        [JsonProperty("attacking_animation")]
//        public object AttackingAnimation { get; set; }

//        [JsonProperty("attacking_animation_fade_out")]
//        public object AttackingAnimationFadeOut { get; set; }

//        [JsonProperty("attacking_muzzle_animation_shift")]
//        public object AttackingMuzzleAnimationShift { get; set; }

//        [JsonProperty("attacking_speed")]
//        public object AttackingSpeed { get; set; }

//        [JsonProperty("automated_ammo_count")]
//        public object AutomatedAmmoCount { get; set; }

//        [JsonProperty("base_picture")]
//        public object BasePicture { get; set; }

//        [JsonProperty("base_picture_render_layer")]
//        public object BasePictureRenderLayer { get; set; }

//        [JsonProperty("base_picture_secondary_draw_order")]
//        public object BasePictureSecondaryDrawOrder { get; set; }

//        [JsonProperty("call_for_help_radius")]
//        public object CallForHelpRadius { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("ending_attack_animation")]
//        public object EndingAttackAnimation { get; set; }

//        [JsonProperty("ending_attack_muzzle_animation_shift")]
//        public object EndingAttackMuzzleAnimationShift { get; set; }

//        [JsonProperty("ending_attack_speed")]
//        public object EndingAttackSpeed { get; set; }

//        [JsonProperty("enough_fuel_indicator_picture")]
//        public object EnoughFuelIndicatorPicture { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("fluid_box")]
//        public object FluidBox { get; set; }

//        [JsonProperty("fluid_buffer_input_flow")]
//        public object FluidBufferInputFlow { get; set; }

//        [JsonProperty("fluid_buffer_size")]
//        public object FluidBufferSize { get; set; }

//        [JsonProperty("folded_animation")]
//        public object FoldedAnimation { get; set; }

//        [JsonProperty("folded_muzzle_animation_shift")]
//        public object FoldedMuzzleAnimationShift { get; set; }

//        [JsonProperty("folding_animation")]
//        public object FoldingAnimation { get; set; }

//        [JsonProperty("folding_muzzle_animation_shift")]
//        public object FoldingMuzzleAnimationShift { get; set; }

//        [JsonProperty("folding_speed")]
//        public object FoldingSpeed { get; set; }

//        [JsonProperty("gun_animation_render_layer")]
//        public object GunAnimationRenderLayer { get; set; }

//        [JsonProperty("gun_animation_secondary_draw_order")]
//        public object GunAnimationSecondaryDrawOrder { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("indicator_light")]
//        public object IndicatorLight { get; set; }

//        [JsonProperty("inventory_size")]
//        public object InventorySize { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("muzzle_animation")]
//        public object MuzzleAnimation { get; set; }

//        [JsonProperty("muzzle_light")]
//        public object MuzzleLight { get; set; }

//        [JsonProperty("not_enough_fuel_indicator_picture")]
//        public object NotEnoughFuelIndicatorPicture { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("prepare_range")]
//        public object PrepareRange { get; set; }

//        [JsonProperty("prepared_animation")]
//        public object PreparedAnimation { get; set; }

//        [JsonProperty("prepared_muzzle_animation_shift")]
//        public object PreparedMuzzleAnimationShift { get; set; }

//        [JsonProperty("preparing_animation")]
//        public object PreparingAnimation { get; set; }

//        [JsonProperty("preparing_muzzle_animation_shift")]
//        public object PreparingMuzzleAnimationShift { get; set; }

//        [JsonProperty("preparing_speed")]
//        public object PreparingSpeed { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("rotation_speed")]
//        public object RotationSpeed { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("shoot_in_prepare_state")]
//        public object ShootInPrepareState { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("font", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Font : TypedNamedBase
//    {

//        [JsonProperty("from")]
//        public object From { get; set; }

//        [JsonProperty("size")]
//        public object Size { get; set; }

//        [JsonProperty("border")]
//        public object Border { get; set; }

//        [JsonProperty("border_color")]
//        public object BorderColor { get; set; }

//    }

//    [JsonObject("gate", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Gate : TypedNamedBase
//    {

//        [JsonProperty("activation_distance")]
//        public object ActivationDistance { get; set; }

//        [JsonProperty("close_sound")]
//        public object CloseSound { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("fast_replaceable_group")]
//        public object FastReplaceableGroup { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("horizontal_animation")]
//        public object HorizontalAnimation { get; set; }

//        [JsonProperty("horizontal_base")]
//        public object HorizontalBase { get; set; }

//        [JsonProperty("horizontal_rail_animation_left")]
//        public object HorizontalRailAnimationLeft { get; set; }

//        [JsonProperty("horizontal_rail_animation_right")]
//        public object HorizontalRailAnimationRight { get; set; }

//        [JsonProperty("horizontal_rail_base")]
//        public object HorizontalRailBase { get; set; }

//        [JsonProperty("horizontal_rail_base_mask")]
//        public object HorizontalRailBaseMask { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("open_sound")]
//        public object OpenSound { get; set; }

//        [JsonProperty("opening_speed")]
//        public object OpeningSpeed { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("timeout_to_close")]
//        public object TimeoutToClose { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("vertical_animation")]
//        public object VerticalAnimation { get; set; }

//        [JsonProperty("vertical_base")]
//        public object VerticalBase { get; set; }

//        [JsonProperty("vertical_rail_animation_left")]
//        public object VerticalRailAnimationLeft { get; set; }

//        [JsonProperty("vertical_rail_animation_right")]
//        public object VerticalRailAnimationRight { get; set; }

//        [JsonProperty("vertical_rail_base")]
//        public object VerticalRailBase { get; set; }

//        [JsonProperty("vertical_rail_base_mask")]
//        public object VerticalRailBaseMask { get; set; }

//        [JsonProperty("wall_patch")]
//        public object WallPatch { get; set; }

//    }

//    [JsonObject("group-attack-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class GroupAttackAchievement : TypedNamedBase
//    {

//        [JsonProperty("amount")]
//        public object Amount { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//    }

//    [JsonObject("gui-style", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class GuiStyle : TypedNamedBase
//    {

//        [JsonProperty("ability_slot_style")]
//        public object AbilitySlotStyle { get; set; }

//        [JsonProperty("achievement_card_progressbar_style")]
//        public object AchievementCardProgressbarStyle { get; set; }

//        [JsonProperty("achievement_description_label_style")]
//        public object AchievementDescriptionLabelStyle { get; set; }

//        [JsonProperty("achievement_failed_description_label_style")]
//        public object AchievementFailedDescriptionLabelStyle { get; set; }

//        [JsonProperty("achievement_failed_reason_label_style")]
//        public object AchievementFailedReasonLabelStyle { get; set; }

//        [JsonProperty("achievement_failed_title_label_style")]
//        public object AchievementFailedTitleLabelStyle { get; set; }

//        [JsonProperty("achievement_locked_description_label_style")]
//        public object AchievementLockedDescriptionLabelStyle { get; set; }

//        [JsonProperty("achievement_locked_progress_label_style")]
//        public object AchievementLockedProgressLabelStyle { get; set; }

//        [JsonProperty("achievement_locked_title_label_style")]
//        public object AchievementLockedTitleLabelStyle { get; set; }

//        [JsonProperty("achievement_percent_label_style")]
//        public object AchievementPercentLabelStyle { get; set; }

//        [JsonProperty("achievement_pinned_card_progressbar_style")]
//        public object AchievementPinnedCardProgressbarStyle { get; set; }

//        [JsonProperty("achievement_progressbar_style")]
//        public object AchievementProgressbarStyle { get; set; }

//        [JsonProperty("achievement_title_label_style")]
//        public object AchievementTitleLabelStyle { get; set; }

//        [JsonProperty("achievement_unlocked_description_label_style")]
//        public object AchievementUnlockedDescriptionLabelStyle { get; set; }

//        [JsonProperty("achievement_unlocked_title_label_style")]
//        public object AchievementUnlockedTitleLabelStyle { get; set; }

//        [JsonProperty("achievements_flow_style")]
//        public object AchievementsFlowStyle { get; set; }

//        [JsonProperty("activity_bar_style")]
//        public object ActivityBarStyle { get; set; }

//        [JsonProperty("available_preview_technology_slot_style")]
//        public object AvailablePreviewTechnologySlotStyle { get; set; }

//        [JsonProperty("available_technology_slot_style")]
//        public object AvailableTechnologySlotStyle { get; set; }

//        [JsonProperty("battery_progressbar_style")]
//        public object BatteryProgressbarStyle { get; set; }

//        [JsonProperty("bob-inserter-blank")]
//        public object BobInserterBlank { get; set; }

//        [JsonProperty("bob-inserter-checkbox")]
//        public object BobInserterCheckbox { get; set; }

//        [JsonProperty("bob-inserter-checkbox-drop")]
//        public object BobInserterCheckboxDrop { get; set; }

//        [JsonProperty("bob-inserter-checkbox-pickup")]
//        public object BobInserterCheckboxPickup { get; set; }

//        [JsonProperty("bob-inserter-checkbox-small")]
//        public object BobInserterCheckboxSmall { get; set; }

//        [JsonProperty("bob-inserter-middle")]
//        public object BobInserterMiddle { get; set; }

//        [JsonProperty("bob-table")]
//        public object BobTable { get; set; }

//        [JsonProperty("bold_label_style")]
//        public object BoldLabelStyle { get; set; }

//        [JsonProperty("bonus_progressbar_style")]
//        public object BonusProgressbarStyle { get; set; }

//        [JsonProperty("browse_games_gui_line_style")]
//        public object BrowseGamesGuiLineStyle { get; set; }

//        [JsonProperty("browse_games_scroll_pane_style")]
//        public object BrowseGamesScrollPaneStyle { get; set; }

//        [JsonProperty("browse_games_table_style")]
//        public object BrowseGamesTableStyle { get; set; }

//        [JsonProperty("browse_mods_scroll_pane_style")]
//        public object BrowseModsScrollPaneStyle { get; set; }

//        [JsonProperty("browse_mods_table_style")]
//        public object BrowseModsTableStyle { get; set; }

//        [JsonProperty("burning_progressbar_style")]
//        public object BurningProgressbarStyle { get; set; }

//        [JsonProperty("button_style")]
//        public object ButtonStyle { get; set; }

//        [JsonProperty("campaign_levels_listbox_style")]
//        public object CampaignLevelsListboxStyle { get; set; }

//        [JsonProperty("campaigns_listbox_style")]
//        public object CampaignsListboxStyle { get; set; }

//        [JsonProperty("caption_label_style")]
//        public object CaptionLabelStyle { get; set; }

//        [JsonProperty("checkbox_style")]
//        public object CheckboxStyle { get; set; }

//        [JsonProperty("circuit_condition_sign_button_style")]
//        public object CircuitConditionSignButtonStyle { get; set; }

//        [JsonProperty("console_input_textfield_style")]
//        public object ConsoleInputTextfieldStyle { get; set; }

//        [JsonProperty("control_settings_table_style")]
//        public object ControlSettingsTableStyle { get; set; }

//        [JsonProperty("controls_settings_button_style")]
//        public object ControlsSettingsButtonStyle { get; set; }

//        [JsonProperty("crafting_queue_slot_style")]
//        public object CraftingQueueSlotStyle { get; set; }

//        [JsonProperty("cursor_box")]
//        public object CursorBox { get; set; }

//        [JsonProperty("custom_games_listbox_style")]
//        public object CustomGamesListboxStyle { get; set; }

//        [JsonProperty("description_flow_style")]
//        public object DescriptionFlowStyle { get; set; }

//        [JsonProperty("description_label_style")]
//        public object DescriptionLabelStyle { get; set; }

//        [JsonProperty("description_remark_label_style")]
//        public object DescriptionRemarkLabelStyle { get; set; }

//        [JsonProperty("description_title_label_style")]
//        public object DescriptionTitleLabelStyle { get; set; }

//        [JsonProperty("description_value_label_style")]
//        public object DescriptionValueLabelStyle { get; set; }

//        [JsonProperty("dialog_button_style")]
//        public object DialogButtonStyle { get; set; }

//        [JsonProperty("disabled_technology_slot_style")]
//        public object DisabledTechnologySlotStyle { get; set; }

//        [JsonProperty("dropdown_style")]
//        public object DropdownStyle { get; set; }

//        [JsonProperty("edit_label_button_style")]
//        public object EditLabelButtonStyle { get; set; }

//        [JsonProperty("electric_network_sections_table_style")]
//        public object ElectricNetworkSectionsTableStyle { get; set; }

//        [JsonProperty("electric_satisfaction_in_description_progressbar_style")]
//        public object ElectricSatisfactionInDescriptionProgressbarStyle { get; set; }

//        [JsonProperty("electric_satisfaction_progressbar_style")]
//        public object ElectricSatisfactionProgressbarStyle { get; set; }

//        [JsonProperty("electric_usage_label_style")]
//        public object ElectricUsageLabelStyle { get; set; }

//        [JsonProperty("entity_info_label_style")]
//        public object EntityInfoLabelStyle { get; set; }

//        [JsonProperty("failed_achievement_frame_style")]
//        public object FailedAchievementFrameStyle { get; set; }

//        [JsonProperty("fake_disabled_button_style")]
//        public object FakeDisabledButtonStyle { get; set; }

//        [JsonProperty("flip_button_style_left")]
//        public object FlipButtonStyleLeft { get; set; }

//        [JsonProperty("flip_button_style_right")]
//        public object FlipButtonStyleRight { get; set; }

//        [JsonProperty("floating_train_station_listbox_style")]
//        public object FloatingTrainStationListboxStyle { get; set; }

//        [JsonProperty("flow_style")]
//        public object FlowStyle { get; set; }

//        [JsonProperty("frame_caption_label_style")]
//        public object FrameCaptionLabelStyle { get; set; }

//        [JsonProperty("frame_in_right_container_style")]
//        public object FrameInRightContainerStyle { get; set; }

//        [JsonProperty("frame_style")]
//        public object FrameStyle { get; set; }

//        [JsonProperty("goal_frame_style")]
//        public object GoalFrameStyle { get; set; }

//        [JsonProperty("goal_label_style")]
//        public object GoalLabelStyle { get; set; }

//        [JsonProperty("graph_style")]
//        public object GraphStyle { get; set; }

//        [JsonProperty("green_circuit_network_content_slot_style")]
//        public object GreenCircuitNetworkContentSlotStyle { get; set; }

//        [JsonProperty("green_slot_button_style")]
//        public object GreenSlotButtonStyle { get; set; }

//        [JsonProperty("health_progressbar_style")]
//        public object HealthProgressbarStyle { get; set; }

//        [JsonProperty("horizontal_line_style")]
//        public object HorizontalLineStyle { get; set; }

//        [JsonProperty("image_tab_selected_slot_style")]
//        public object ImageTabSelectedSlotStyle { get; set; }

//        [JsonProperty("image_tab_slot_style")]
//        public object ImageTabSlotStyle { get; set; }

//        [JsonProperty("inner_frame_in_outer_frame_style")]
//        public object InnerFrameInOuterFrameStyle { get; set; }

//        [JsonProperty("inner_frame_style")]
//        public object InnerFrameStyle { get; set; }

//        [JsonProperty("invalid_label_style")]
//        public object InvalidLabelStyle { get; set; }

//        [JsonProperty("label_style")]
//        public object LabelStyle { get; set; }

//        [JsonProperty("listbox_item_style")]
//        public object ListboxItemStyle { get; set; }

//        [JsonProperty("listbox_style")]
//        public object ListboxStyle { get; set; }

//        [JsonProperty("load_game_mod_disabled_listbox_item_style")]
//        public object LoadGameModDisabledListboxItemStyle { get; set; }

//        [JsonProperty("load_game_mod_invalid_listbox_item_style")]
//        public object LoadGameModInvalidListboxItemStyle { get; set; }

//        [JsonProperty("load_game_mods_listbox_style")]
//        public object LoadGameModsListboxStyle { get; set; }

//        [JsonProperty("locked_achievement_frame_style")]
//        public object LockedAchievementFrameStyle { get; set; }

//        [JsonProperty("logistic_button_selected_slot_style")]
//        public object LogisticButtonSelectedSlotStyle { get; set; }

//        [JsonProperty("logistic_button_slot_style")]
//        public object LogisticButtonSlotStyle { get; set; }

//        [JsonProperty("machine_frame_style")]
//        public object MachineFrameStyle { get; set; }

//        [JsonProperty("machine_right_part_flow_style")]
//        public object MachineRightPartFlowStyle { get; set; }

//        [JsonProperty("map_settings_dropdown_style")]
//        public object MapSettingsDropdownStyle { get; set; }

//        [JsonProperty("menu_button_style")]
//        public object MenuButtonStyle { get; set; }

//        [JsonProperty("menu_frame_style")]
//        public object MenuFrameStyle { get; set; }

//        [JsonProperty("menu_message_style")]
//        public object MenuMessageStyle { get; set; }

//        [JsonProperty("minimap_frame_style")]
//        public object MinimapFrameStyle { get; set; }

//        [JsonProperty("mining_progressbar_style")]
//        public object MiningProgressbarStyle { get; set; }

//        [JsonProperty("mod_dependency_invalid_label_style")]
//        public object ModDependencyInvalidLabelStyle { get; set; }

//        [JsonProperty("mod_disabled_listbox_item_style")]
//        public object ModDisabledListboxItemStyle { get; set; }

//        [JsonProperty("mod_info_flow_style")]
//        public object ModInfoFlowStyle { get; set; }

//        [JsonProperty("mod_invalid_listbox_item_style")]
//        public object ModInvalidListboxItemStyle { get; set; }

//        [JsonProperty("mod_list_label_style")]
//        public object ModListLabelStyle { get; set; }

//        [JsonProperty("mod_updates_available_listbox_item_style")]
//        public object ModUpdatesAvailableListboxItemStyle { get; set; }

//        [JsonProperty("mods_listbox_style")]
//        public object ModsListboxStyle { get; set; }

//        [JsonProperty("multiplayer_activity_bar_style")]
//        public object MultiplayerActivityBarStyle { get; set; }

//        [JsonProperty("naked_frame_style")]
//        public object NakedFrameStyle { get; set; }

//        [JsonProperty("no_path_station_in_schedule_in_train_view_listbox_item_style")]
//        public object NoPathStationInScheduleInTrainViewListboxItemStyle { get; set; }

//        [JsonProperty("not_available_preview_technology_slot_style")]
//        public object NotAvailablePreviewTechnologySlotStyle { get; set; }

//        [JsonProperty("not_available_slot_button_style")]
//        public object NotAvailableSlotButtonStyle { get; set; }

//        [JsonProperty("not_available_technology_slot_style")]
//        public object NotAvailableTechnologySlotStyle { get; set; }

//        [JsonProperty("not_working_weapon_button_style")]
//        public object NotWorkingWeaponButtonStyle { get; set; }

//        [JsonProperty("notice_textbox_style")]
//        public object NoticeTextboxStyle { get; set; }

//        [JsonProperty("number_textfield_style")]
//        public object NumberTextfieldStyle { get; set; }

//        [JsonProperty("omitted_technology_slot_style")]
//        public object OmittedTechnologySlotStyle { get; set; }

//        [JsonProperty("outer_frame_style")]
//        public object OuterFrameStyle { get; set; }

//        [JsonProperty("partially_promised_crafting_queue_slot_style")]
//        public object PartiallyPromisedCraftingQueueSlotStyle { get; set; }

//        [JsonProperty("player_listbox_item_style")]
//        public object PlayerListboxItemStyle { get; set; }

//        [JsonProperty("production_progressbar_style")]
//        public object ProductionProgressbarStyle { get; set; }

//        [JsonProperty("progressbar_style")]
//        public object ProgressbarStyle { get; set; }

//        [JsonProperty("promised_crafting_queue_slot_style")]
//        public object PromisedCraftingQueueSlotStyle { get; set; }

//        [JsonProperty("quick_bar_frame_style")]
//        public object QuickBarFrameStyle { get; set; }

//        [JsonProperty("radiobutton_style")]
//        public object RadiobuttonStyle { get; set; }

//        [JsonProperty("recipe_tooltip_cannot_craft_label_style")]
//        public object RecipeTooltipCannotCraftLabelStyle { get; set; }

//        [JsonProperty("recipe_tooltip_transitive_craft_label_style")]
//        public object RecipeTooltipTransitiveCraftLabelStyle { get; set; }

//        [JsonProperty("red_circuit_network_content_slot_style")]
//        public object RedCircuitNetworkContentSlotStyle { get; set; }

//        [JsonProperty("red_slot_button_style")]
//        public object RedSlotButtonStyle { get; set; }

//        [JsonProperty("researched_preview_technology_slot_style")]
//        public object ResearchedPreviewTechnologySlotStyle { get; set; }

//        [JsonProperty("researched_technology_slot_style")]
//        public object ResearchedTechnologySlotStyle { get; set; }

//        [JsonProperty("right_bottom_container_frame_style")]
//        public object RightBottomContainerFrameStyle { get; set; }

//        [JsonProperty("right_container_frame_style")]
//        public object RightContainerFrameStyle { get; set; }

//        [JsonProperty("saves_listbox_style")]
//        public object SavesListboxStyle { get; set; }

//        [JsonProperty("scenario_message_dialog_label_style")]
//        public object ScenarioMessageDialogLabelStyle { get; set; }

//        [JsonProperty("scenario_message_dialog_style")]
//        public object ScenarioMessageDialogStyle { get; set; }

//        [JsonProperty("schedule_in_train_view_list_box_style")]
//        public object ScheduleInTrainViewListBoxStyle { get; set; }

//        [JsonProperty("scroll_pane_style")]
//        public object ScrollPaneStyle { get; set; }

//        [JsonProperty("scrollbar_style")]
//        public object ScrollbarStyle { get; set; }

//        [JsonProperty("search_button_style")]
//        public object SearchButtonStyle { get; set; }

//        [JsonProperty("search_flow_style")]
//        public object SearchFlowStyle { get; set; }

//        [JsonProperty("search_mods_button_style")]
//        public object SearchModsButtonStyle { get; set; }

//        [JsonProperty("search_textfield_style")]
//        public object SearchTextfieldStyle { get; set; }

//        [JsonProperty("selected_slot_button_style")]
//        public object SelectedSlotButtonStyle { get; set; }

//        [JsonProperty("shield_progressbar_style")]
//        public object ShieldProgressbarStyle { get; set; }

//        [JsonProperty("side_menu_button_style")]
//        public object SideMenuButtonStyle { get; set; }

//        [JsonProperty("side_menu_frame_style")]
//        public object SideMenuFrameStyle { get; set; }

//        [JsonProperty("slider_style")]
//        public object SliderStyle { get; set; }

//        [JsonProperty("slot_button_style")]
//        public object SlotButtonStyle { get; set; }

//        [JsonProperty("slot_table_spacing_flow_style")]
//        public object SlotTableSpacingFlowStyle { get; set; }

//        [JsonProperty("slot_table_style")]
//        public object SlotTableStyle { get; set; }

//        [JsonProperty("slot_with_filter_button_style")]
//        public object SlotWithFilterButtonStyle { get; set; }

//        [JsonProperty("small_slot_button_style")]
//        public object SmallSlotButtonStyle { get; set; }

//        [JsonProperty("statistics_progressbar_style")]
//        public object StatisticsProgressbarStyle { get; set; }

//        [JsonProperty("steam_friend_listbox_item_style")]
//        public object SteamFriendListboxItemStyle { get; set; }

//        [JsonProperty("switch_quickbar_button_style")]
//        public object SwitchQuickbarButtonStyle { get; set; }

//        [JsonProperty("tab_style")]
//        public object TabStyle { get; set; }

//        [JsonProperty("table_spacing_flow_style")]
//        public object TableSpacingFlowStyle { get; set; }

//        [JsonProperty("table_style")]
//        public object TableStyle { get; set; }

//        [JsonProperty("target_station_in_schedule_in_train_view_listbox_item_style")]
//        public object TargetStationInScheduleInTrainViewListboxItemStyle { get; set; }

//        [JsonProperty("technology_preview_frame_style")]
//        public object TechnologyPreviewFrameStyle { get; set; }

//        [JsonProperty("technology_slot_button_style")]
//        public object TechnologySlotButtonStyle { get; set; }

//        [JsonProperty("textbox_style")]
//        public object TextboxStyle { get; set; }

//        [JsonProperty("textfield_style")]
//        public object TextfieldStyle { get; set; }

//        [JsonProperty("tool_bar_frame_style")]
//        public object ToolBarFrameStyle { get; set; }

//        [JsonProperty("tool_equip_gui_label_style")]
//        public object ToolEquipGuiLabelStyle { get; set; }

//        [JsonProperty("tooltip_description_label_style")]
//        public object TooltipDescriptionLabelStyle { get; set; }

//        [JsonProperty("tooltip_flow_style")]
//        public object TooltipFlowStyle { get; set; }

//        [JsonProperty("tooltip_frame_style")]
//        public object TooltipFrameStyle { get; set; }

//        [JsonProperty("tooltip_label_style")]
//        public object TooltipLabelStyle { get; set; }

//        [JsonProperty("tooltip_title_label_style")]
//        public object TooltipTitleLabelStyle { get; set; }

//        [JsonProperty("tracked_achievements_flow_style")]
//        public object TrackedAchievementsFlowStyle { get; set; }

//        [JsonProperty("tracking_off_button_style")]
//        public object TrackingOffButtonStyle { get; set; }

//        [JsonProperty("tracking_on_button_style")]
//        public object TrackingOnButtonStyle { get; set; }

//        [JsonProperty("train_station_listbox_style")]
//        public object TrainStationListboxStyle { get; set; }

//        [JsonProperty("train_station_schedule_listbox_style")]
//        public object TrainStationScheduleListboxStyle { get; set; }

//        [JsonProperty("unlocked_achievement_frame_style")]
//        public object UnlockedAchievementFrameStyle { get; set; }

//        [JsonProperty("vehicle_health_progressbar_style")]
//        public object VehicleHealthProgressbarStyle { get; set; }

//        [JsonProperty("working_weapon_button_style")]
//        public object WorkingWeaponButtonStyle { get; set; }

//    }

//    [JsonObject("item-request-proxy", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ItemRequestProxy : TypedNamedBase
//    {

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("picture")]
//        public object Picture { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//    }

//    public partial class ItemSubgroup
//    {

//        [JsonProperty("order")]
//        public object Order { get; set; }

//    }

//    [JsonObject("kill-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class KillAchievement : TypedNamedBase
//    {

//        [JsonProperty("amount")]
//        public object Amount { get; set; }

//        [JsonProperty("damage_type")]
//        public object DamageType { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("steam_stats_name")]
//        public object SteamStatsName { get; set; }

//        [JsonProperty("type_to_kill")]
//        public object TypeToKill { get; set; }

//        [JsonProperty("in_vehicle")]
//        public object InVehicle { get; set; }

//        [JsonProperty("personally")]
//        public object Personally { get; set; }

//    }

//    [JsonObject("leaf-particle", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class LeafParticle : TypedNamedBase
//    {

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("life_time")]
//        public object LifeTime { get; set; }

//        [JsonProperty("movement_modifier")]
//        public object MovementModifier { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("shadows")]
//        public object Shadows { get; set; }

//    }

//    [JsonObject("loader", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Loader : TypedNamedBase
//    {

//        [JsonProperty("animation_speed_coefficient")]
//        public object AnimationSpeedCoefficient { get; set; }

//        [JsonProperty("belt_horizontal")]
//        public object BeltHorizontal { get; set; }

//        [JsonProperty("belt_vertical")]
//        public object BeltVertical { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("ending_bottom")]
//        public object EndingBottom { get; set; }

//        [JsonProperty("ending_patch")]
//        public object EndingPatch { get; set; }

//        [JsonProperty("ending_side")]
//        public object EndingSide { get; set; }

//        [JsonProperty("ending_top")]
//        public object EndingTop { get; set; }

//        [JsonProperty("fast_replaceable_group")]
//        public object FastReplaceableGroup { get; set; }

//        [JsonProperty("filter_count")]
//        public object FilterCount { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("starting_bottom")]
//        public object StartingBottom { get; set; }

//        [JsonProperty("starting_side")]
//        public object StartingSide { get; set; }

//        [JsonProperty("starting_top")]
//        public object StartingTop { get; set; }

//        [JsonProperty("structure")]
//        public object Structure { get; set; }

//    }

//    [JsonObject("module-category", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ModuleCategory : TypedNamedBase
//    {

//    }

//    [JsonObject("offshore-pump", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class OffshorePump : TypedNamedBase
//    {

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_points")]
//        public object CircuitWireConnectionPoints { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("fluid")]
//        public object Fluid { get; set; }

//        [JsonProperty("fluid_box")]
//        public object FluidBox { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("picture")]
//        public object Picture { get; set; }

//        [JsonProperty("pumping_speed")]
//        public object PumpingSpeed { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("tile_width")]
//        public object TileWidth { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("particle-source", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ParticleSource : TypedNamedBase
//    {

//        [JsonProperty("height")]
//        public object Height { get; set; }

//        [JsonProperty("height_deviation")]
//        public object HeightDeviation { get; set; }

//        [JsonProperty("horizontal_speed")]
//        public object HorizontalSpeed { get; set; }

//        [JsonProperty("horizontal_speed_deviation")]
//        public object HorizontalSpeedDeviation { get; set; }

//        [JsonProperty("particle")]
//        public object Particle { get; set; }

//        [JsonProperty("time_before_start")]
//        public object TimeBeforeStart { get; set; }

//        [JsonProperty("time_before_start_deviation")]
//        public object TimeBeforeStartDeviation { get; set; }

//        [JsonProperty("time_to_live")]
//        public object TimeToLive { get; set; }

//        [JsonProperty("time_to_live_deviation")]
//        public object TimeToLiveDeviation { get; set; }

//        [JsonProperty("vertical_speed")]
//        public object VerticalSpeed { get; set; }

//        [JsonProperty("vertical_speed_deviation")]
//        public object VerticalSpeedDeviation { get; set; }

//    }

//    [JsonObject("player-damaged-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class PlayerDamagedAchievement : TypedNamedBase
//    {

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("minimum_damage")]
//        public object MinimumDamage { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("should_survive")]
//        public object ShouldSurvive { get; set; }

//        [JsonProperty("steam_stats_name")]
//        public object SteamStatsName { get; set; }

//        [JsonProperty("type_of_dealer")]
//        public object TypeOfDealer { get; set; }

//    }

//    [JsonObject("power-switch", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class PowerSwitch : TypedNamedBase
//    {

//        [JsonProperty("circuit_wire_connection_point")]
//        public object CircuitWireConnectionPoint { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("led_off")]
//        public object LedOff { get; set; }

//        [JsonProperty("led_on")]
//        public object LedOn { get; set; }

//        [JsonProperty("left_wire_connection_point")]
//        public object LeftWireConnectionPoint { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("overlay_loop")]
//        public object OverlayLoop { get; set; }

//        [JsonProperty("overlay_start")]
//        public object OverlayStart { get; set; }

//        [JsonProperty("overlay_start_delay")]
//        public object OverlayStartDelay { get; set; }

//        [JsonProperty("power_on_animation")]
//        public object PowerOnAnimation { get; set; }

//        [JsonProperty("right_wire_connection_point")]
//        public object RightWireConnectionPoint { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("wire_max_distance")]
//        public object WireMaxDistance { get; set; }

//    }

//    [JsonObject("produce-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ProduceAchievement : TypedNamedBase
//    {

//        [JsonProperty("amount")]
//        public object Amount { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("item_product")]
//        public object ItemProduct { get; set; }

//        [JsonProperty("limited_to_one_game")]
//        public object LimitedToOneGame { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("steam_stats_name")]
//        public object SteamStatsName { get; set; }

//    }

//    [JsonObject("produce-per-hour-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ProducePerHourAchievement : TypedNamedBase
//    {

//        [JsonProperty("amount")]
//        public object Amount { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("item_product")]
//        public object ItemProduct { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("steam_stats_name")]
//        public object SteamStatsName { get; set; }

//    }

//    [JsonObject("rail-chain-signal", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RailChainSignal : TypedNamedBase
//    {

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("blue_light")]
//        public object BlueLight { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("fast_replaceable_group")]
//        public object FastReplaceableGroup { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("green_light")]
//        public object GreenLight { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("orange_light")]
//        public object OrangeLight { get; set; }

//        [JsonProperty("rail_piece")]
//        public object RailPiece { get; set; }

//        [JsonProperty("red_light")]
//        public object RedLight { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("selection_box_offsets")]
//        public object SelectionBoxOffsets { get; set; }

//    }

//    [JsonObject("rail-planner", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RailPlanner : TypedNamedBase
//    {

//        [JsonProperty("curved_rail")]
//        public object CurvedRail { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("place_result")]
//        public object PlaceResult { get; set; }

//        [JsonProperty("stack_size")]
//        public object StackSize { get; set; }

//        [JsonProperty("straight_rail")]
//        public object StraightRail { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("repair-tool", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RepairTool : TypedNamedBase
//    {

//        [JsonProperty("durability")]
//        public object Durability { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("stack_size")]
//        public object StackSize { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("research-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ResearchAchievement : TypedNamedBase
//    {

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("technology")]
//        public object Technology { get; set; }

//        [JsonProperty("research_all")]
//        public object ResearchAll { get; set; }

//    }

//    [JsonObject("resource-category", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class ResourceCategory : TypedNamedBase
//    {

//    }

//    [JsonObject("roboport-equipment", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RoboportEquipment : TypedNamedBase
//    {

//        [JsonProperty("charge_approach_distance")]
//        public object ChargeApproachDistance { get; set; }

//        [JsonProperty("charging_distance")]
//        public object ChargingDistance { get; set; }

//        [JsonProperty("charging_energy")]
//        public object ChargingEnergy { get; set; }

//        [JsonProperty("charging_station_count")]
//        public object ChargingStationCount { get; set; }

//        [JsonProperty("charging_station_shift")]
//        public object ChargingStationShift { get; set; }

//        [JsonProperty("charging_threshold_distance")]
//        public object ChargingThresholdDistance { get; set; }

//        [JsonProperty("construction_radius")]
//        public object ConstructionRadius { get; set; }

//        [JsonProperty("energy_consumption")]
//        public object EnergyConsumption { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("recharging_animation")]
//        public object RechargingAnimation { get; set; }

//        [JsonProperty("recharging_light")]
//        public object RechargingLight { get; set; }

//        [JsonProperty("robot_limit")]
//        public object RobotLimit { get; set; }

//        [JsonProperty("shape")]
//        public object Shape { get; set; }

//        [JsonProperty("spawn_and_station_height")]
//        public object SpawnAndStationHeight { get; set; }

//        [JsonProperty("sprite")]
//        public object Sprite { get; set; }

//        [JsonProperty("stationing_offset")]
//        public object StationingOffset { get; set; }

//        [JsonProperty("take_result")]
//        public object TakeResult { get; set; }

//    }

//    [JsonObject("rocket-silo", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RocketSilo : TypedNamedBase
//    {

//        [JsonProperty("active_energy_usage")]
//        public object ActiveEnergyUsage { get; set; }

//        [JsonProperty("alarm_trigger")]
//        public object AlarmTrigger { get; set; }

//        [JsonProperty("allowed_effects")]
//        public object AllowedEffects { get; set; }

//        [JsonProperty("arm_01_back_animation")]
//        public object Arm01BackAnimation { get; set; }

//        [JsonProperty("arm_02_right_animation")]
//        public object Arm02RightAnimation { get; set; }

//        [JsonProperty("arm_03_front_animation")]
//        public object Arm03FrontAnimation { get; set; }

//        [JsonProperty("base_day_sprite")]
//        public object BaseDaySprite { get; set; }

//        [JsonProperty("base_engine_light")]
//        public object BaseEngineLight { get; set; }

//        [JsonProperty("base_front_sprite")]
//        public object BaseFrontSprite { get; set; }

//        [JsonProperty("base_light")]
//        public object BaseLight { get; set; }

//        [JsonProperty("base_night_sprite")]
//        public object BaseNightSprite { get; set; }

//        [JsonProperty("clamps_off_trigger")]
//        public object ClampsOffTrigger { get; set; }

//        [JsonProperty("clamps_on_trigger")]
//        public object ClampsOnTrigger { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("crafting_categories")]
//        public object CraftingCategories { get; set; }

//        [JsonProperty("crafting_speed")]
//        public object CraftingSpeed { get; set; }

//        [JsonProperty("door_back_open_offset")]
//        public object DoorBackOpenOffset { get; set; }

//        [JsonProperty("door_back_sprite")]
//        public object DoorBackSprite { get; set; }

//        [JsonProperty("door_front_open_offset")]
//        public object DoorFrontOpenOffset { get; set; }

//        [JsonProperty("door_front_sprite")]
//        public object DoorFrontSprite { get; set; }

//        [JsonProperty("door_opening_speed")]
//        public object DoorOpeningSpeed { get; set; }

//        [JsonProperty("doors_trigger")]
//        public object DoorsTrigger { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("energy_source")]
//        public object EnergySource { get; set; }

//        [JsonProperty("energy_usage")]
//        public object EnergyUsage { get; set; }

//        [JsonProperty("fixed_recipe")]
//        public object FixedRecipe { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("hole_light_sprite")]
//        public object HoleLightSprite { get; set; }

//        [JsonProperty("hole_sprite")]
//        public object HoleSprite { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("idle_energy_usage")]
//        public object IdleEnergyUsage { get; set; }

//        [JsonProperty("ingredient_count")]
//        public object IngredientCount { get; set; }

//        [JsonProperty("lamp_energy_usage")]
//        public object LampEnergyUsage { get; set; }

//        [JsonProperty("light_blinking_speed")]
//        public object LightBlinkingSpeed { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("module_specification")]
//        public object ModuleSpecification { get; set; }

//        [JsonProperty("raise_rocket_trigger")]
//        public object RaiseRocketTrigger { get; set; }

//        [JsonProperty("red_lights_back_sprites")]
//        public object RedLightsBackSprites { get; set; }

//        [JsonProperty("red_lights_front_sprites")]
//        public object RedLightsFrontSprites { get; set; }

//        [JsonProperty("rocket_entity")]
//        public object RocketEntity { get; set; }

//        [JsonProperty("rocket_glow_overlay_sprite")]
//        public object RocketGlowOverlaySprite { get; set; }

//        [JsonProperty("rocket_parts_required")]
//        public object RocketPartsRequired { get; set; }

//        [JsonProperty("rocket_shadow_overlay_sprite")]
//        public object RocketShadowOverlaySprite { get; set; }

//        [JsonProperty("satellite_animation")]
//        public object SatelliteAnimation { get; set; }

//        [JsonProperty("satellite_shadow_animation")]
//        public object SatelliteShadowAnimation { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("shadow_sprite")]
//        public object ShadowSprite { get; set; }

//        [JsonProperty("silo_fade_out_end_distance")]
//        public object SiloFadeOutEndDistance { get; set; }

//        [JsonProperty("silo_fade_out_start_distance")]
//        public object SiloFadeOutStartDistance { get; set; }

//        [JsonProperty("times_to_blink")]
//        public object TimesToBlink { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//    }

//    [JsonObject("rocket-silo-rocket", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RocketSiloRocket : TypedNamedBase
//    {

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("collision_mask")]
//        public object CollisionMask { get; set; }

//        [JsonProperty("dying_explosion")]
//        public object DyingExplosion { get; set; }

//        [JsonProperty("effects_fade_in_end_distance")]
//        public object EffectsFadeInEndDistance { get; set; }

//        [JsonProperty("effects_fade_in_start_distance")]
//        public object EffectsFadeInStartDistance { get; set; }

//        [JsonProperty("engine_starting_speed")]
//        public object EngineStartingSpeed { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("flying_acceleration")]
//        public object FlyingAcceleration { get; set; }

//        [JsonProperty("flying_speed")]
//        public object FlyingSpeed { get; set; }

//        [JsonProperty("flying_trigger")]
//        public object FlyingTrigger { get; set; }

//        [JsonProperty("full_render_layer_switch_distance")]
//        public object FullRenderLayerSwitchDistance { get; set; }

//        [JsonProperty("glow_light")]
//        public object GlowLight { get; set; }

//        [JsonProperty("inventory_size")]
//        public object InventorySize { get; set; }

//        [JsonProperty("rising_speed")]
//        public object RisingSpeed { get; set; }

//        [JsonProperty("rocket_flame_animation")]
//        public object RocketFlameAnimation { get; set; }

//        [JsonProperty("rocket_flame_left_animation")]
//        public object RocketFlameLeftAnimation { get; set; }

//        [JsonProperty("rocket_flame_left_rotation")]
//        public object RocketFlameLeftRotation { get; set; }

//        [JsonProperty("rocket_flame_right_animation")]
//        public object RocketFlameRightAnimation { get; set; }

//        [JsonProperty("rocket_flame_right_rotation")]
//        public object RocketFlameRightRotation { get; set; }

//        [JsonProperty("rocket_glare_overlay_sprite")]
//        public object RocketGlareOverlaySprite { get; set; }

//        [JsonProperty("rocket_launch_offset")]
//        public object RocketLaunchOffset { get; set; }

//        [JsonProperty("rocket_render_layer_switch_distance")]
//        public object RocketRenderLayerSwitchDistance { get; set; }

//        [JsonProperty("rocket_rise_offset")]
//        public object RocketRiseOffset { get; set; }

//        [JsonProperty("rocket_shadow_sprite")]
//        public object RocketShadowSprite { get; set; }

//        [JsonProperty("rocket_smoke_bottom1_animation")]
//        public object RocketSmokeBottom1Animation { get; set; }

//        [JsonProperty("rocket_smoke_bottom2_animation")]
//        public object RocketSmokeBottom2Animation { get; set; }

//        [JsonProperty("rocket_smoke_top1_animation")]
//        public object RocketSmokeTop1Animation { get; set; }

//        [JsonProperty("rocket_smoke_top2_animation")]
//        public object RocketSmokeTop2Animation { get; set; }

//        [JsonProperty("rocket_smoke_top3_animation")]
//        public object RocketSmokeTop3Animation { get; set; }

//        [JsonProperty("rocket_sprite")]
//        public object RocketSprite { get; set; }

//        [JsonProperty("rocket_visible_distance_from_center")]
//        public object RocketVisibleDistanceFromCenter { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("shadow_fade_out_end_ratio")]
//        public object ShadowFadeOutEndRatio { get; set; }

//        [JsonProperty("shadow_fade_out_start_ratio")]
//        public object ShadowFadeOutStartRatio { get; set; }

//        [JsonProperty("shadow_slave_entity")]
//        public object ShadowSlaveEntity { get; set; }

//    }

//    [JsonObject("rocket-silo-rocket-shadow", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class RocketSiloRocketShadow : TypedNamedBase
//    {

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("collision_mask")]
//        public object CollisionMask { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//    }

//    [JsonObject("selection-tool", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class SelectionTool : TypedNamedBase
//    {

//        [JsonProperty("alt_selection_color")]
//        public object AltSelectionColor { get; set; }

//        [JsonProperty("alt_selection_cursor_box_type")]
//        public object AltSelectionCursorBoxType { get; set; }

//        [JsonProperty("alt_selection_mode")]
//        public object AltSelectionMode { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("localised_name")]
//        public object LocalisedName { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("selection_color")]
//        public object SelectionColor { get; set; }

//        [JsonProperty("selection_cursor_box_type")]
//        public object SelectionCursorBoxType { get; set; }

//        [JsonProperty("selection_mode")]
//        public object SelectionMode { get; set; }

//        [JsonProperty("stack_size")]
//        public object StackSize { get; set; }

//        [JsonProperty("stackable")]
//        public object Stackable { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("simple-entity", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class SimpleEntity : TypedNamedBase
//    {

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("render_layer")]
//        public object RenderLayer { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("autoplace")]
//        public object Autoplace { get; set; }

//        [JsonProperty("loot")]
//        public object Loot { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("mined_sound")]
//        public object MinedSound { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//    }

//    [JsonObject("smoke-with-trigger", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class SmokeWithTrigger : TypedNamedBase
//    {

//        [JsonProperty("action")]
//        public object Action { get; set; }

//        [JsonProperty("action_frequency")]
//        public object ActionFrequency { get; set; }

//        [JsonProperty("affected_by_wind")]
//        public object AffectedByWind { get; set; }

//        [JsonProperty("animation")]
//        public object Animation { get; set; }

//        [JsonProperty("color")]
//        public object Color { get; set; }

//        [JsonProperty("cyclic")]
//        public object Cyclic { get; set; }

//        [JsonProperty("duration")]
//        public object Duration { get; set; }

//        [JsonProperty("fade_away_duration")]
//        public object FadeAwayDuration { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("show_when_smoke_off")]
//        public object ShowWhenSmokeOff { get; set; }

//        [JsonProperty("slow_down_factor")]
//        public object SlowDownFactor { get; set; }

//        [JsonProperty("spread_duration")]
//        public object SpreadDuration { get; set; }

//    }

//    [JsonObject("storage-tank", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class StorageTank : TypedNamedBase
//    {

//        [JsonProperty("circuit_connector_sprites")]
//        public object CircuitConnectorSprites { get; set; }

//        [JsonProperty("circuit_wire_connection_points")]
//        public object CircuitWireConnectionPoints { get; set; }

//        [JsonProperty("circuit_wire_max_distance")]
//        public object CircuitWireMaxDistance { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("fast_replaceable_group")]
//        public object FastReplaceableGroup { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("flow_length_in_ticks")]
//        public object FlowLengthInTicks { get; set; }

//        [JsonProperty("fluid_box")]
//        public object FluidBox { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("vehicle_impact_sound")]
//        public object VehicleImpactSound { get; set; }

//        [JsonProperty("window_bounding_box")]
//        public object WindowBoundingBox { get; set; }

//        [JsonProperty("working_sound")]
//        public object WorkingSound { get; set; }

//    }

//    [JsonObject("straight-rail", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class StraightRail : TypedNamedBase
//    {

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("pictures")]
//        public object Pictures { get; set; }

//        [JsonProperty("rail_category")]
//        public object RailCategory { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//    }

//    [JsonObject("stream", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Stream : TypedNamedBase
//    {

//        [JsonProperty("action")]
//        public object Action { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("ground_light")]
//        public object GroundLight { get; set; }

//        [JsonProperty("particle")]
//        public object Particle { get; set; }

//        [JsonProperty("particle_buffer_size")]
//        public object ParticleBufferSize { get; set; }

//        [JsonProperty("particle_end_alpha")]
//        public object ParticleEndAlpha { get; set; }

//        [JsonProperty("particle_fade_out_threshold")]
//        public object ParticleFadeOutThreshold { get; set; }

//        [JsonProperty("particle_horizontal_speed")]
//        public object ParticleHorizontalSpeed { get; set; }

//        [JsonProperty("particle_horizontal_speed_deviation")]
//        public object ParticleHorizontalSpeedDeviation { get; set; }

//        [JsonProperty("particle_loop_exit_threshold")]
//        public object ParticleLoopExitThreshold { get; set; }

//        [JsonProperty("particle_loop_frame_count")]
//        public object ParticleLoopFrameCount { get; set; }

//        [JsonProperty("particle_spawn_interval")]
//        public object ParticleSpawnInterval { get; set; }

//        [JsonProperty("particle_spawn_timeout")]
//        public object ParticleSpawnTimeout { get; set; }

//        [JsonProperty("particle_start_alpha")]
//        public object ParticleStartAlpha { get; set; }

//        [JsonProperty("particle_start_scale")]
//        public object ParticleStartScale { get; set; }

//        [JsonProperty("particle_vertical_acceleration")]
//        public object ParticleVerticalAcceleration { get; set; }

//        [JsonProperty("shadow")]
//        public object Shadow { get; set; }

//        [JsonProperty("smoke_sources")]
//        public object SmokeSources { get; set; }

//        [JsonProperty("spine_animation")]
//        public object SpineAnimation { get; set; }

//        [JsonProperty("stream_light")]
//        public object StreamLight { get; set; }

//        [JsonProperty("working_sound_disabled")]
//        public object WorkingSoundDisabled { get; set; }

//    }

//    [JsonObject("tile-ghost", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class TileGhost : TypedNamedBase
//    {

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//    }

//    [JsonObject("tool", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class Tool : TypedNamedBase
//    {

//        [JsonProperty("durability")]
//        public object Durability { get; set; }

//        [JsonProperty("durability_description_key")]
//        public object DurabilityDescriptionKey { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("stack_size")]
//        public object StackSize { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//    }

//    [JsonObject("train-path-achievement", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class TrainPathAchievement : TypedNamedBase
//    {

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("minimum_distance")]
//        public object MinimumDistance { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("steam_stats_name")]
//        public object SteamStatsName { get; set; }

//    }

//    [JsonObject("underground-belt", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class UndergroundBelt : TypedNamedBase
//    {

//        [JsonProperty("animation_speed_coefficient")]
//        public object AnimationSpeedCoefficient { get; set; }

//        [JsonProperty("belt_horizontal")]
//        public object BeltHorizontal { get; set; }

//        [JsonProperty("belt_vertical")]
//        public object BeltVertical { get; set; }

//        [JsonProperty("collision_box")]
//        public object CollisionBox { get; set; }

//        [JsonProperty("corpse")]
//        public object Corpse { get; set; }

//        [JsonProperty("ending_bottom")]
//        public object EndingBottom { get; set; }

//        [JsonProperty("ending_patch")]
//        public object EndingPatch { get; set; }

//        [JsonProperty("ending_side")]
//        public object EndingSide { get; set; }

//        [JsonProperty("ending_top")]
//        public object EndingTop { get; set; }

//        [JsonProperty("fast_replaceable_group")]
//        public object FastReplaceableGroup { get; set; }

//        [JsonProperty("flags")]
//        public object Flags { get; set; }

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("max_distance")]
//        public object MaxDistance { get; set; }

//        [JsonProperty("max_health")]
//        public object MaxHealth { get; set; }

//        [JsonProperty("minable")]
//        public object Minable { get; set; }

//        [JsonProperty("resistances")]
//        public object Resistances { get; set; }

//        [JsonProperty("selection_box")]
//        public object SelectionBox { get; set; }

//        [JsonProperty("speed")]
//        public object Speed { get; set; }

//        [JsonProperty("starting_bottom")]
//        public object StartingBottom { get; set; }

//        [JsonProperty("starting_side")]
//        public object StartingSide { get; set; }

//        [JsonProperty("starting_top")]
//        public object StartingTop { get; set; }

//        [JsonProperty("structure")]
//        public object Structure { get; set; }

//        [JsonProperty("underground_sprite")]
//        public object UndergroundSprite { get; set; }

//        [JsonProperty("distance_to_enter")]
//        public object DistanceToEnter { get; set; }

//    }

//    [JsonObject("utility-sprites", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class UtilitySprites : TypedNamedBase
//    {

//        [JsonProperty("arrow_button")]
//        public object ArrowButton { get; set; }

//        [JsonProperty("battery_indicator")]
//        public object BatteryIndicator { get; set; }

//        [JsonProperty("fluid_indication_arrow")]
//        public object FluidIndicationArrow { get; set; }

//        [JsonProperty("grey_placement_indicator_leg")]
//        public object GreyPlacementIndicatorLeg { get; set; }

//        [JsonProperty("grey_rail_signal_placement_indicator")]
//        public object GreyRailSignalPlacementIndicator { get; set; }

//        [JsonProperty("indication_arrow")]
//        public object IndicationArrow { get; set; }

//        [JsonProperty("indication_line")]
//        public object IndicationLine { get; set; }

//        [JsonProperty("placement_indicator_leg")]
//        public object PlacementIndicatorLeg { get; set; }

//        [JsonProperty("rail_planner_indication_arrow")]
//        public object RailPlannerIndicationArrow { get; set; }

//        [JsonProperty("rail_planner_indication_arrow_too_far")]
//        public object RailPlannerIndicationArrowTooFar { get; set; }

//        [JsonProperty("rail_signal_placement_indicator")]
//        public object RailSignalPlacementIndicator { get; set; }

//        [JsonProperty("reset")]
//        public object Reset { get; set; }

//        [JsonProperty("short_indication_line")]
//        public object ShortIndicationLine { get; set; }

//        [JsonProperty("train_stop_placement_indicator")]
//        public object TrainStopPlacementIndicator { get; set; }

//    }

//    [JsonObject("virtual-signal", MemberSerialization = MemberSerialization.OptIn)]
//    public partial class VirtualSignal : TypedNamedBase
//    {

//        [JsonProperty("icon")]
//        public object Icon { get; set; }

//        [JsonProperty("order")]
//        public object Order { get; set; }

//        [JsonProperty("subgroup")]
//        public object Subgroup { get; set; }

//        [JsonProperty("special_signal")]
//        public object SpecialSignal { get; set; }

//    }

//}
