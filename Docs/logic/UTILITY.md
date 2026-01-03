# Utility Services Logic (Electricity, Water, Internet)

## Overview
This document defines the logic for **utility services** used in the Room Management system.
The goal is to simulate **realistic service billing** while keeping the design **simple and extensible**.

The services are:
- Electricity
- Water
- Internet

These services are **independent from Room and Customer logic**, and are calculated separately.

---

## Service Concept

A Utility Service represents a **consumable resource** associated with a room booking.

### Common Properties
- ServiceId
- ServiceName
- UnitPrice
- UsageAmount
- BillingType

Services **do not know about customers or room states**.

---

## 1️⃣ Electricity Service

### Description
Electricity cost is calculated based on **meter usage (kWh)**.

### Properties
- UnitPrice (per kWh)
- PreviousMeter
- CurrentMeter

### Calculation Rule
```
Usage = CurrentMeter - PreviousMeter
Cost = Usage × UnitPrice
```

### Notes
- Usage must be ≥ 0
- Meter values are recorded at check-in and check-out

---

## 2️⃣ Water Service

### Description
Water is billed similarly to electricity but may have **tiered pricing**.

### Properties
- UnitPrice (per m³)
- UsageAmount

### Calculation Rule (Simple)
```
Cost = UsageAmount × UnitPrice
```

### Optional Rule (Advanced)
- First X units at base price
- Remaining units at higher price

---

## 3️⃣ Internet Service

### Description
Internet is billed as a **fixed fee**, not usage-based.

### Properties
- MonthlyFee
- IsActive

### Calculation Rule
```
If IsActive:
    Cost = MonthlyFee
Else:
    Cost = 0
```

### Notes
- Internet fee is independent of stay duration (simplified model)

---

## Billing Flow

Utility services are calculated **after room price**.

```
Room Price
→ Customer Discount
→ Utility Services Cost
→ Final Bill
```

Utility services **do not apply discounts or vouchers** by default.

---

## Design Patterns Used

| Purpose | Pattern |
|------|--------|
| Service abstraction | Strategy |
| Service composition | Composite (optional) |
| Billing calculation | Service Interface |

---

## Project Structure (Suggested)

```
Services/
│
├── Utilities/
│   ├── IUtilityService.cs
│   ├── ElectricityService.cs
│   ├── WaterService.cs
│   ├── InternetService.cs
```
---

## Design Justification (For Presentation)

> “Utility services are modeled as independent components.  
Each service encapsulates its own billing logic, making the system easy to extend when new services are added.”

---

## Conclusion

This utility logic:
- Reflects real billing behavior
- Is easy to understand and implement
- Keeps concerns separated
- Integrates cleanly with Room and Customer logic

---
