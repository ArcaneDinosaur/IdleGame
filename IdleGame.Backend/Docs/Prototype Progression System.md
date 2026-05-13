# **Prototype Progression System Document**

## **1\. Overview**

This document defines the complete **production‑grade progression system** for the game. It describes the player experience, the structure of generators, the currency loop, the unlock system, and the scaling rules that govern long‑term progression. This is a **design document**, not a technical specification.

The goal is to provide a clear, modular, extensible progression framework that supports future systems such as prestige, achievements, quests, and automation.

---

## **2\. Core Player Loop**

The core loop is simple, readable, and designed for long‑term engagement:

1. **Generators produce Dust** over time.  
2. The player **collects Dust** passively.  
3. The player **spends Dust** to:  
   * Unlock new generators  
   * Level up existing generators  
4. Higher‑level generators produce **more Dust**, accelerating progression.  
5. New generators introduce **new production sources**, expanding the economy.

This loop repeats indefinitely, with scaling systems ensuring a smooth early game and a meaningful late game.

---

## **3\. Currency System**

### **3.1 Dust**

Dust is the primary soft currency. It is:

* Earned passively from generators  
* Spent to level up generators  
* Used to unlock new generators

Dust is generated continuously and accumulated globally.

### **3.2 Production Flow**

1. Each generator has a **base DPS** (Dust per second).  
2. Leveling a generator increases its DPS.  
3. Total DPS is the sum of all active generators.  
4. Dust increases over time based on total DPS.

---

## **4\. Generators**

Generators are the backbone of the progression system.

### **4.1 GeneratorData (Design‑Time)**

Each generator has:

* **Name**  
* **Base Cost**  
* **Base DPS**  
* **Unlock Condition** (ScriptableObject)  
* **Visual/UI Data**

This data is static and defined in the editor.

### **4.2 GeneratorInstance (Runtime)**

When a generator is unlocked, a runtime instance is created. It tracks:

* Current level  
* Current cost  
* Current DPS  
* UI state

### **4.3 Cost Scaling**

Generator cost increases exponentially:

* Each level multiplies the cost by a constant factor.  
* This ensures long‑term progression and prevents trivial maxing.

### **4.4 DPS Scaling**

Generator DPS increases linearly:

* Each level adds a fixed amount of DPS.  
* This keeps DPS predictable and easy to balance.

---

## **5\. Unlock System**

The unlock system determines when generators become available.

### **5.1 Philosophy**

The unlock system is:

* **Push‑based**: Conditions notify the system when met.  
* **Polymorphic**: Each condition type defines its own logic.  
* **Stateful**: Conditions unlock once and never again.  
* **Data‑Driven**: Conditions are ScriptableObjects.  
* **Runtime‑Instanced**: Each generator gets its own clone.  
* **Event‑Driven**: Conditions subscribe directly to relevant events.

### **5.2 UnlockCondition (Design‑Level Description)**

Each UnlockCondition:

* Knows which generator it unlocks  
* Subscribes to the events it needs  
* Evaluates itself when events fire  
* Fires an `OnUnlocked` event when satisfied  
* Tracks whether it has already unlocked

### **5.3 Condition Lifecycle**

1. A runtime clone is created for each generator.  
2. The clone is initialized with its target generator.  
3. It subscribes to relevant events.  
4. When an event fires, it evaluates its rule.  
5. If the rule becomes true for the first time, it unlocks the generator.  
6. It unsubscribes from events.

### 

### **5.4 Supported Unlock Types**

* **AlwaysUnlockedCondition**: Unlocks immediately.  
* **DustUnlockCondition**: Unlocks when Dust reaches a threshold.  
* **GeneratorLevelUnlockCondition**: Unlocks when another generator reaches a required level.

Future unlock types can be added without modifying existing systems.

---

## **6\. UI / UX Behavior**

### **6.1 Locked State**

A generator appears in the UI but is:

* Greyed out  
* Non‑interactive  
* Shows its unlock requirement

### **6.2 Unlocked State**

When unlocked:

* The generator becomes fully visible  
* The player can purchase levels  
* The generator begins producing Dust

### **6.3 Level‑Up Flow**

1. Player clicks the generator.  
2. Dust is spent.  
3. Level increases.  
4. DPS increases.  
5. UI updates.

---

## **7\. Progression Scaling**

### **7.1 Early Game**

* Fast unlocks  
* Low costs  
* Rapid generator acquisition

### **7.2 Mid Game**

* Costs rise exponentially  
* DPS increases steadily  
* Unlocks require strategic investment

### **7.3 Late Game**

* High‑level generators dominate production  
* Unlocks require long‑term goals  
* Prestige systems (future) reset progression for bonuses

---

## **8\. Future Systems (Placeholders)**

These systems are not implemented yet but are planned:

### **8.1 Prestige**

Reset progression for permanent bonuses.

### **8.2 Achievements**

Reward players for reaching milestones.

### **8.3 Quests**

Provide short‑term goals and rewards.

### **8.4 Automation**

Automate generator leveling and Dust collection.

---

## **9\. Glossary**

**Dust** – Primary soft currency.

**Generator** – A unit that produces Dust over time.

**GeneratorData** – Static design‑time data for a generator.

**GeneratorInstance** – Runtime representation of a generator.

**UnlockCondition** – A ScriptableObject defining when a generator unlocks.

**DPS** – Dust per second.

**Push‑Based** – Conditions notify the system when met.

**Polymorphic** – Multiple condition types share a common interface.

**Stateful** – Conditions track whether they have already unlocked.

**Runtime Clone** – A per‑generator instance of a ScriptableObject.

---

This document now reflects a complete, production‑grade progression system suitable for long‑term development and public release.

