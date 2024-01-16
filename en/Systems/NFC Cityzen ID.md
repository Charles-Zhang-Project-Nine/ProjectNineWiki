# NFC Cityzen ID

Tags: NFC, #Technical, #Specification, Tellus World

## Cityzen ID

The simplistic format would be **linear serial number** starting from 1, however: 1) This lacks crucial identifying features; 2) This is too easy to make up - not to guess, but too easy to make up. Instead, we can use a more stratigical method combining several useful informations:

1. Raw Serial: A serial number is still useful and can occassionally be used, this is a number starting from 1.
2. Class Ranking: *M* for Medalian origin, *T* for human origin.
3. Date of Birth: Format in "YYYY-mm-DD" for official date of birth.
4. Security Level: A dash plus a number like "-L9" identifies security level.
5. Date of Enrollment: Format in YYYY-mm-DD for official recognition of CofN Cityzenship.
6. GUID: A biologically bound GUID for a paritcular cityzen.
7. Cityzen Status: "N" for Non-Cityzen (Not tracked but on file), "M" for Marked Outsider (tracked), "V" for visitor, "C" for cityzen, "P" for past cityzen, "R" for recovered cityzen (e.g. after adolescence trip).

A **Cityzen ID** uniquely identifies an individual throughout its **biological life** and will NOT change. If a cityzen changes its life form, new identities are assumed and new cityzen ID is allocated.

Four pieces of key identifying information (and thus should be kept secret) are: Raw Serial + Full Name + Date of Birth + Photo/Physical Appearance.

Those additional information are usually also associated with a Cityzen:

1. SCP
2. SCL

## PR Number

PRs will have more counts than actual cityzens since during a cityzen's life time they may get lost change new PRs.