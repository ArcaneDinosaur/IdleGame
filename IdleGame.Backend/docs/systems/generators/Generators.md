# Generators

1. What Generators Are (Design Overview)
    Generators are the core progression units of the game.
    They:

        - Produce Dust passively over time

        - Can be leveled up to increase production

        - Unlock progressively as the player meets conditions

        - Form the backbone of the early, mid, and late‑game economy

    Generators are always visible in the UI, even when locked.

2. Player Experience

    2.1 Locked State

        - Greyed out

        - Shows unlock requirement

        - Not interactive

    2.2 Unlocked State

        - Fully visible

        - Player can level it up

        - Begins producing Dust immediately

    2.3 Leveling Flow

        - Player clicks the generator

        - Dust is spent

        - Level increases

        - DPS increases

        - UI updates

3. Generator Definitions (Design‑Time Data)

    Generators are defined in JSON files and loaded at startup. Each generator definition includes:

        - BasePassiveRate — starting Dust per second

        - PassiveRatePerLevel — linear DPS increase per level

        - BaseTapAmount — Dust gained when tapping (if tapping is supported)

        - TapAmountPerLevel — tap scaling

        - BaseUpgradeCost — cost of level 1

        - UpgradeCostMultiplier — exponential cost scaling

    These values are immutable and loaded via init‑only properties.

4. Generator Instances (Runtime Data)

    When a generator unlocks, the game creates a runtime instance that tracks:

        - Current level

        - Current DPS

        - Current upgrade cost

        - Whether it is unlocked

        - UI state

    Runtime instances are stateful, while definitions are static.

5. Production Rules

    5.1 DPS Formula

        DPS scales linearly: DPS = BasePassiveRate + (PassiveRatePerLevel × Level)

    5.2 Tap Formula

        If tapping is enabled: TapAmount = BaseTapAmount + (TapAmountPerLevel × Level)

    5.3 Total Production

        Total Dust per second is the sum of all unlocked generators.

6. Cost Scaling Rules

        Generator upgrade cost scales exponentially:
            Cost(level) = BaseUpgradeCost × (UpgradeCostMultiplier ^ (level - 1))

    This ensures:

        Fast early progression

        Smooth mid‑game

        Long‑term scalability

7. Unlocking Generators
    Generators unlock through the Unlock System, which is:

        Push‑based

        Event‑driven

        Polymorphic

        Data‑driven

    Supported unlock types:

        AlwaysUnlocked

        DustThreshold

        GeneratorLevelRequirement

    Each generator has exactly one unlock condition.

8. JSON Example (Arcane Dust Generator):

        {
            "BasePassiveRate": 1,
            "PassiveRatePerLevel": 0.5,
            "BaseTapAmount": 5,
            "TapAmountPerLevel": 1,
            "BaseUpgradeCost": 100,
            "UpgradeCostMultiplier": 1.15
        }