# Simple Room Management Logic

## Overview
This project models a **simple but realistic room management system** inspired by hotel systems.
The focus is **clean OOP design**, **easy extensibility**, and **basic real-world rules**.

---

## Core Room Concept

A room represents a rentable unit with basic rules.

### Room Properties
- RoomId
- RoomType (Standard, VIP, Family)
- BaseCapacity
- MaxCapacity
- BasePrice
- State

The Room itself **does not contain pricing logic**.

---
---
Base Price, capacity
- Standard : 1,2 Mil VND for month, capacity 2 -> 4 
- VIP : 3 MIL VND for month 3 -> 5
- Faminly: 10MIL VND for month 4 -> 8
---
## Room States (Lifecycle)

Rooms change state during their lifecycle.

### States
- Available
- Reserved
- Occupied
- Cleaning

### Rules
- Available → can be reserved
- Reserved → can check-in or cancel
- Occupied → can check-out
- Cleaning → cannot be booked

**Pattern used:** State Pattern

---

## Pricing Logic

Price depends on room type.

### Pricing Strategies
- StandardPricing = base price
- VipPricing = base price * 1.5
- FamilyPricing = base price * 2    

Each strategy calculates base price differently.

**Pattern used:** Strategy Pattern

---

## Extra Fees

Extra services add cost dynamically.

### Common Fees
- Weekend fee
- Extra guest fee : ExtraFee for First extra guest, Multiply for 120% for 2 or above 
- Extra bed fee: Bed number * bed fee number

Fees can be stacked together.

**Pattern used:** Decorator Pattern

---

## Capacity Rules

| Guests | Result |
|------|--------|
| ≤ BaseCapacity | Allowed |
| > Base & ≤ Max | Extra fee |
| > Max | Rejected |

---

## Booking Flow

Create Room  
→ Available  
→ Reserve  
→ Check-In  
→ Check-Out  
→ Cleaning  
→ Available

---

## Design Patterns Used

| Purpose | Pattern |
|------|--------|
| Pricing | Strategy |
| Extra fees | Decorator |
| Room state | State |
| Room creation | Factory |

---

## Conclusion

This design:
- Is easy to understand
- Matches real systems at a basic level
- Is suitable for OOP coursework
- Can be extended without modifying existing code
