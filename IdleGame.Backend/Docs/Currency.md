1. Overview
	Dust is the game’s primary soft currency.
	Future currencies will expand the economy but Dust remains the foundation.

2. Player Experience
	Dust increases automatically over time

	Higher‑level generators produce more Dust

	Dust is spent to level and unlock generators

	Future currencies will unlock deeper systems

3. Dust: Core Currency
    3.1 How Dust Is Generated

        Passive Production
		DPS = BasePassiveRate + (PassiveRatePerLevel × Level)
	    TotalDPS = Sum of all generator DPS

		Tap Production (optional)
		TapAmount = BaseTapAmount + (TapAmountPerLevel × Level)

3.2 How Dust Is Spent
	Leveling generators

	Unlocking generators

	Future systems (prestige, crafting, automation)

	3.3 Dust Scaling Rules

		Cost scaling (exponential):
		Cost(level) = BaseUpgradeCost × (UpgradeCostMultiplier ^ (level - 1))

		Production scaling (linear):
		DPS = BasePassiveRate + (PassiveRatePerLevel × Level)

4. Future Currencies
	These currencies are not implemented yet, but the design anticipates them.

4.1 Premium Currency (Name TBD)
	Used for:

		Utility upgrades

		Extra rerolls

		Cosmetic unlocks

		Rare convenience features

	Earned via:

		Very rare drops

		Purchases

		Pity timer system

	Stored globally.

4.2 Crafting Materials
	Used for:

		Crafting items

		Upgrading generators

		Unlocking recipes

	Earned via:

		Quests

		Generator drops

		Special events

4.3 Prestige Currency
	Earned when the player resets progression.
	Used for:

		Permanent upgrades

		Meta‑progression

		Automation systems

	This currency defines the late‑game loop.

4.4 Event‑Specific Currencies
	Temporary currencies used during limited‑time events.

5. Data Representation
	Dust: double

	Premium currency: int or long

	Crafting materials: dictionary of string → int

	Prestige currency: double or BigDouble (depending on scale)

6. Future Extensions
	Dust and future currencies will integrate with:

		Achievements

		Quests

		Crafting

		Automation

		Prestige resets