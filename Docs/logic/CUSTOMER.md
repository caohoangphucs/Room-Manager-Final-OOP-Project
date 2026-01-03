# Simple Customer Logic (Room Booking Context)

## Overview
This document defines a **simple but realistic Customer logic** used together with the Room Management system.
It focuses on **pricing-related behavior**, **voucher handling**, and **priority rules**, without over-complicating the design.

The goal is to support **clean design**, **design pattern practice**, and **realistic booking rules**.

---

## Customer Concept

A Customer represents a person who books and uses rooms.

### Customer Properties
- CustomerId
- FullName
- CustomerType (Normal, Student, VIP)
- LoyaltyPoints
- ActiveVouchers

The Customer **does not calculate room price directly**.

---

## Customer Types

### Supported Types
- NormalCustomer
- StudentCustomer
- VipCustomer

Each type may receive different benefits.

| Type | Benefit |
|----|-------|
| Normal | No default discount |
| Student | Percentage discount |
| VIP | Higher discount + priority |

**Pattern used:** Strategy Pattern (Discount Strategy)

---

## Discount Logic

Discounts are applied **after room base pricing**.

### Discount Sources
1. Customer type discount
2. Voucher discount
3. Loyalty discount (optional)

### Discount Rules
- Discounts are cumulative but capped (e.g. max 40%)
- Voucher validity must be checked
- Expired vouchers are ignored

---

## Voucher Logic

Vouchers represent promotional discounts.

### Voucher Properties
- VoucherCode
- DiscountType (Percentage / Fixed)
- DiscountValue
- ExpiryDate
- IsStackable

### Voucher Rules
- Expired vouchers cannot be used
- Non-stackable vouchers override others
- Highest discount voucher is applied first

**Pattern used:** Strategy Pattern (Voucher Discount Strategy)

---

## Priority Rules

Some customers have higher priority during booking.

### Priority Order
1. VIP Customer
2. Student Customer
3. Normal Customer

Priority affects:
- Room availability when demand is high
- Booking queue order

---

## Pricing Flow (Customer Perspective)

```
Room Base Price
→ Room Extra Fees
→ Customer Discount Strategy
→ Voucher Discount
→ Final Price
```

Customer logic never modifies Room logic directly.

---

## Design Patterns Used

| Purpose | Pattern |
|------|--------|
| Customer discount | Strategy |
| Voucher discount | Strategy |
| Voucher composition | Chain of Responsibility (optional) |
| Customer creation | Factory |

---

## Simple Booking Flow

Create Customer  
→ Select Room  
→ Apply Pricing Strategy  
→ Apply Customer Discount  
→ Apply Voucher  
→ Confirm Booking  

---

## Project Structure (Suggested)

```
Customer/
│
├── Models/
│   ├── Customer.cs
│   ├── StudentCustomer.cs
│   ├── VipCustomer.cs
│
├── Discounts/
│   ├── IDiscountStrategy.cs
│   ├── StudentDiscount.cs
│   ├── VipDiscount.cs
│
├── Vouchers/
│   ├── Voucher.cs
│   ├── PercentageVoucher.cs
│   ├── FixedVoucher.cs
│
├── Factory/
│   └── CustomerFactory.cs
```

---
