# CofN Open Platform

Tags: System, NFC, Tellus World

The integration of this system goes way deeper than basic information querying - this might serve as the fundation for "No One Needs to Work Ever - NoJob per TLO" concept.

## (project nine, System, Structure, Diagram) CofN Open Platform

```yaml
# In this document we will depict the relation between various components of CofN Open Platform
Name: CofN Open Platform
Type: Infrastructure, Protocol, System, City Service, Social Service
Description: Comprehensive network diagram providing accessible, transparent, efficient access to all aspects of services of daily city life. Each node represents a **service provider** (as infrastructure), which are routed to corresponding **service endpoints**. ¶Each service endpoint has an arbitrarily assigned 3-digit service ID (besides a hidden GUID, which is a global string), which also serves as a namespace denominator - subentities are denoted using a 1-5 letter symbol (like stock). ¶Every intranet domain must attach to one of the CofN Open Platform Service Endpoints to be indexable.
Children:
  - Name: CofN Job Network
    Children:
      - Name: City Service Job Catalog
      - Name: Freelance Job Catalog
      - Name: Organizational Job Catalog
      - Name: Cityzen Duty Catalog
  - Name: CofN Health Network
    Children:
      - Name: CofN Hospital System
        Children: 
          - Name: CofN Hospitals
          - Name: CofN Clinics
      - Name: CofN Ambulance Network
        Description: Real-time information on available Ambulances
  - Name: CofN Traffic Network
    Description: Real-time and static transportation system data.
    Children: 
      - Name: Transportation Service Network
        Description: Bus stations, train stations etc.
        Children:
          - Name: Transportation Station Database
            Children: 
              - Name: CofN Ambulance Stations
              - Name: CofN Fire Engine Stations
              - Name: CofN Bus Stations
              - Name: CofN Train Stations
              - Name: CofN Airport Stations
          - Name: Real-Time Traffic Service
            Children: 
              - Name: Real-Time Air Traffic
  - Name: CofN Library Network
    Children:
      - Name: CofN Libraries
        Type: Infrastructure, City Service
        Description: City-managed library buildings scattered across the city.
        Children:
          - Name: CofN Library (Scarborough)
          - Name: CofN Library (North York)
          - Name: CofN Library (Vaughan)
          - Name: CofN Library (Markham)
          - Name: CofN Library (Don Valley)
      - Name: Whisper School Libraries
        Type: Organizational, Education
        Description: Various Whisper School libraries.
        Children: 
          - Name: Whisper Central Library
            Todo: Pending alternative/more memorable name
  - Name: CofN Culture Network
    Children: 
      - Name: Cultural Service Network
        Children: 
          - Name: CofN Cemetery Catalog
            Description: Database for cemetery information including "Underworld" residences.
      - Name: Cultural Planning Committee
      - Name: One World Advisor Group
  - Name: CofN People Network
    Children:
      - Name: CofN People's General Profile Catalog
      - Name: CofN Customizable Personal Profile Archive
      - Name: CofN Social Platform Interface (Software Use)
  - Name: CofN Merchandise Network
    Children:
      - Name: Virtual Shopping Portal
        Children:
          - Name: Immersive Interface
          - Name: Catalog Interface
  - Name: CofN Food Network
    Children:
      - Name: CofN Food Catalog
      - Name: CofN Restaurant Catalog
  - Name: CofN City Service Network
    Children:
      - Name: Cityzen Service
      - Name: Tourist Service
      - Name: Diplomacy Service
      - Name: Extraterrestrial Service
  - Name: CofN Educational Resource Network
  - Name: CofN Information Technology Archive
    Children:
      - Name: CofN Software Archive
      - Name: CofN Digital Asset Archive
  - Name: CofN Encyclopedia
  - Name: CofN Mapping Services
  - Name: CofN Banking Network
    Children:
      - Name: Cityzen Bank
      - Name: Private Banking Services
        Children:
          - Name: TD Bank
          - Name: Scotiabank
      - Name: Insurance Services
      - Name: Personal Wealth Management Platform
  - Name: Development Central
    Children:
      - Name: Programming Endpoints
        Children:
          - Name: CofN Open Platform Documentation
            Children:
              - Name: Programming Languages
                Description: A survey of all programming languages and programming platforms and environments that are used in CofN development and production environments.
                Draft: C++ for core systems, C# for CLI and Interoperability, HTML and JavaScript as major presentation interface.
          - Name: CofN Open Platform API Reference
          - Name: CofN Open Platform Usage Guides (Examples)
          - Name: CofN Open Platform Online Development Environment
          - Name: CofN Open Platform Cloudservice Database
            Children:
              - Name: Read-Only Network Inspector
              - Name: DMI (Direct Manipulation Interface)
          - Name: CofN Open Platform Inquiries
          - Name: CofN Protocol, Specification and Standard Suites
            Children: 
              - Name: Computer Network Protocols (Application Layer)
                Children:
                  - Name: Accessible Computing Protocol
                    Description: An interface protocol for developing custom Accessible Interface Points (AIP)
                  - Name: Guardian System Protocol
                    Description: An interface for developing custom Guardian-system enabled devices.
                  - Name: HTML5 (6?)
              - Name: Graphical/User Presentation Standards (Application Layer)
                Children:
                  - Name: Formless Scripting Framework
                  - Name: Universal Form Control Framework
              - Name: Interoperational Standards (Data Layer)
                Children:
                  - Name: Common Intermediate Language
                    Description: Used by .Net Framework.
                  - Name: Hybrid Text/Binary Format
                    Description: A high-level text-first mixed format that contains both text and binary data.
                  - Name: RISC5
                    Description: A low-level processor excutable instruction set architecture (ISA).
                  - Name: Tagged Multi-media Container Format
                    Description: A multi-media audio/video container format that supports tagging and advanced scriptable metadata information.
              - Name: Hardware Interface Protocols (Hardware Layer)
                Children:
                  - Name: IEEE 754 Floating Point Arithmetic
                  - Name: Accessible Computing Specification
                    Description: A specification for custom Accessible Interface Points (AIP).
                  - Name: Guardian System Standard
                    Description: A specification for custom Guardian-system enabled devices.
              - Name: Physical Data Transmission Standards (Data Link Layer)
                Children:
                  - Name: Wi-Fi IEEE802 etc.
              - Name: Low Level Communication Protocols (Network Layer)
                Children:
                  - Name: HTTP
                  - Name: IMAP
                  - Name: SSH (Secure Shell)
                    Description: Used by older console applications.
                  - Name: TCP/IP 6
                  - Name: 
      - Name: Infrastructure Systems
        Children:
          - Name: Distributed Cold Storage Network
            Description: An annoymously distributed infrastructure network for cold storage of all CofN data.
            Children:
              - Name: Immutable Data Store (IDS)
                Description: A suite of hardware/software that is responsible for annoymous immutable data store with automatic backup functionalities.
              - Name: Distributed Cold Storage Server (DCSS)
          - Name: Source Code Services (SourceHub)
          - Name: Container Image Services (DockHub)
  - Name: CofN Residential Network
  - Name: CofN Game World
    Children:
      - Name: One World Management Portal
  - Name: CofN Intranet Portal
  - Name: CofN Insight
    Access: Security Level 9+
    Children: 
      - Name: Government Insight
  - Name: System Administration
    Children:
      - Name: FAQ
      - Name: Issues & Suggestions
  - Name: AI Guide/Search Engine
  - Name: Homo'o Sweet Home (Personal Hub, Individual Hub)
    Description: A place to management personal belongings and customization settings.
    Children:
      - Name: Guardian System (GS)
        Description: All connected physical devices that form an individual's guardian system.
        Children:
          - Name: Phone Ring
          - Name: Smart Necklace
          - Name: Wrist Band
          - Name: Other Connected GS Devices
      - Name: Computational Services
        Children:
          - Name: Personal Mobile Computer (PMC) Management Portal
      - Name: Information Security
        Children:
          - Name: Accessible Interface Point (Record)
            Description: A record of AIP access history and data traces.
          - Name: Data Traces Central
            Description: A record of data trace transaction history.
          - Name: Automobiles record
            Description: A record of occupied Connected Automobiles.
  - Name: Application Store
    Children:
      - Name: Singleton-Variable/Base-app Types
        Description: Single-variable derivable modular base apps.
        Children:
          - Name: CityMap
            Description: A presentation/GUI for CofN Traffic Network, also interfacing other aspects of functionalities e.g. talk with Connected Automobiles
          - Name: SourceHub
            Description: A presentation/app that provides access to SourceHub service. Depending on platform/hardware this app have many variants.
      - Name: Development Tools
        Children:
          - Name: .Net Framework
          - Name: Docker
          - Name: Linux Kernel
  - Name: Identifiable Entity System
    Description: Sort of like a "Barcode for everything" project where all artifacts and manufactured goods are identified through embedded micro chips, including meat products (original inspiration from a scientific american article). People can find the barcode then scan and identify its sources and various other information.
```