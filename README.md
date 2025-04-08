# FalconOps – UAV Mission Control System

## Overview
**FalconOps** is a full-stack UAV simulation and mission control platform. It features a C#/.NET backend, desktop, web, and mobile interfaces, real-time telemetry, SQLite storage, and FitNesse-based acceptance testing.

---

## 🎯 Objectives

- Demonstrate C#/.NET application design, testing, and deployment
- Simulate a realistic UAV use case with mission planning and monitoring
- Exercise every technical requirement from the job description, including:
  - Object-oriented design
  - Git version control
  - Agile workflow
  - Unit and acceptance testing
  - UAV/robotics domain knowledge

---

## 🧱 Architecture

### 📂 Project Structure
- `FalconOps.Core`: Shared logic, models, services
- `FalconOps.API`: RESTful backend for missions & telemetry
- `FalconOps.Simulator`: Telemetry generator
- `FalconOps.Desktop`: WPF desktop control station
- `FalconOps.Web`: React + Redux mission dashboard
- `FalconOps.Mobile`: .NET MAUI Android mission viewer
- `FalconOps.Tests`: Unit tests (xUnit)
- `FalconOps.FitNesse`: Acceptance test definitions

---

## 🗺️ Feature Set

### 1. Mission Planner (WPF)
- Create/edit UAV missions with waypoints, speed, altitude
- Save/load missions via SQLite

### 2. Telemetry Simulator
- Simulates:
  - GPS location
  - Altitude and speed
  - Battery and signal strength
- Streams data using SignalR

### 3. Control Center (Desktop UI)
- Monitor live mission progress
- Real-time telemetry graphs and alert panels
- Log system events and errors

### 4. Web Dashboard (React + Redux)
- Map-based UAV visualization
- Real-time data via SignalR
- Status, warnings, and system health

### 5. Mobile App (.NET MAUI Android)
- Lightweight telemetry viewer
- Mission status and quick controls (Pause, Return Home)

---

## 🧪 Testing Strategy

### Unit Tests
- xUnit + Moq for:
  - Waypoint navigation logic
  - Alert triggering
  - Telemetry parsing
  - SQLite repository tests

### Acceptance Tests (FitNesse)
- Define test tables for:
  - Uploading and validating missions
  - Simulated telemetry stream checks
  - API endpoint validations
- Backed by .NET test fixtures

---

## 🧩 Technologies

| Layer        | Stack                          |
|--------------|---------------------------------|
| Backend      | C# .NET 8 Web API, SQLite       |
| Desktop      | WPF (.NET), MVVM                |
| Web          | React, Redux, Recharts, Leaflet |
| Mobile       | .NET MAUI (Android)             |
| Testing      | xUnit, FitNesse, Moq            |
| Real-Time    | SignalR (WebSocket abstraction) |
| CI/CD (optional) | GitHub Actions / Azure DevOps |

---

## 🌀 Agile Workflow Simulation

- User stories tracked via GitHub Projects board
- Features developed in branches with pull requests
- Commit messages include story/task references
- README and codebase are fully documented

---

## 💡 Optional Bonus Enhancements

- Export mission logs and telemetry to CSV
- Mission replay system (using saved telemetry)
- Dynamic alert system (e.g., low battery, altitude warning)
- Autonomous re-routing on error simulation
- Integrate SpecFlow for Gherkin-style test cases
- 3D UAV viewer using Helix Toolkit or Unity integration

---

## 🚀 Getting Started

1. Clone the repository
2. Open `FalconOps.sln` in Visual Studio 2022+
3. Run database migrations (if needed)
4. Launch projects individually or all together via solution startup config
5. Run FitNesse tests via `FalconOps.FitNesse` server

---

## 👨‍💻 Author

Created by Alfredo Carranza as a showcase project for UAV, Robotics, and Software Engineering excellence.

