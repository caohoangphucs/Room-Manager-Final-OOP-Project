# System Test Scenarios (Room + Customer + Utilities)

This document defines **10 test cases** that together demonstrate **all implemented logic**:
- Room lifecycle
- Pricing strategies
- Extra fees
- Customer types
- Voucher rules
- Utility services (electricity, water, internet)

These tests are **scenario-based**, suitable for:
- Manual testing
- Console demo
- Mapping to unit tests

---

## Test 1 – Standard Room, Normal Customer

**Input**
- Room: Standard
- Customer: Normal
- Guests: within base capacity
- No extra services

**Expected**
- Base room price applied
- No discount
- Final price = base price

---

## Test 2 – VIP Room with Weekend Fee

**Input**
- Room: VIP
- Day: Weekend
- Customer: Normal

**Expected**
- VIP pricing strategy applied
- Weekend fee added
- No customer discount

---

## Test 3 – Student Customer Discount

**Input**
- Room: Standard
- Customer: Student
- No extra services

**Expected**
- Base room price
- Student discount applied
- Final price reduced by student rate

---

## Test 4 – Extra Guest Fee

**Input**
- Room: Standard
- Guests > BaseCapacity but ≤ MaxCapacity

**Expected**
- Extra guest fee applied
- Booking accepted
- Final price includes extra guest cost

---

## Test 5 – Capacity Exceeded

**Input**
- Room: Standard
- Guests > MaxCapacity

**Expected**
- Booking rejected
- Error or validation message shown

---

## Test 6 – Voucher Percentage Discount

**Input**
- Room: VIP
- Customer: Normal
- Voucher: 20% off (valid)

**Expected**
- Voucher discount applied
- Final price reduced by 20%

---

## Test 7 – Voucher Expired

**Input**
- Room: Standard
- Customer: Normal
- Voucher: expired

**Expected**
- Voucher ignored
- Price calculated normally

---

## Test 8 – Electricity & Water Usage

**Input**
- Room booking
- Electricity: 120 kWh
- Water: 15 m³

**Expected**
- Electricity cost = 120 × unit price
- Water cost = 15 × unit price
- Added to final bill

---

## Test 9 – Internet Service Active

**Input**
- Room booking
- Internet service enabled

**Expected**
- Fixed internet fee added
- Independent of stay duration

---

## Test 10 – Full Scenario (All Logic)

**Input**
- Room: VIP
- Customer: Student
- Weekend stay
- Extra guest
- Voucher: valid percentage
- Electricity + Water + Internet services

**Expected**
- VIP pricing strategy applied
- Weekend fee added
- Extra guest fee added
- Student discount applied
- Voucher discount applied (within cap)
- Utility costs added
- Correct final bill produced

---

## Conclusion

These 10 test cases collectively verify:
- All pricing paths
- All customer types
- Voucher rules
- Utility service billing
- System integration

They provide **full coverage for demonstration and evaluation purposes**.
