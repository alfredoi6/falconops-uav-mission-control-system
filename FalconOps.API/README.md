# 🛰️ FalconOps Telemetry Simulator

## Overview

The **FalconOps Telemetry Simulator** is a core component of the UAV Mission Control System, responsible for simulating real-time UAV behavior and generating telemetry data streams. It acts as the virtual pilot of the UAV, executing mission plans and communicating with other parts of the system through structured data exchange and real-time updates.

This module is built to reflect real-world UAV control environments while showcasing software architecture, real-time data handling, and simulation strategies.

---

## Purpose

- Simulate realistic UAV flight over pre-planned mission paths
- Generate and transmit telemetry data such as GPS coordinates, altitude, battery level, and signal strength
- Serve real-time data to connected systems (desktop, web, and mobile)
- Store telemetry logs in the backend database for future replay or analysis
- Provide hooks for acceptance testing through FitNesse

---

## Functional Responsibilities

### 1. Mission Loading
- Retrieves mission data from the centralized SQLite database
- Validates mission structure (waypoints, speeds, altitudes)
- Prepares the simulation engine to follow the designated flight plan

### 2. Flight Execution
- Simulates the UAV flying along mission waypoints using calculated motion
- Handles transitions between waypoints and final mission completion
- Manages mission states (Idle, In-Flight, Return-to-Base, Completed)

### 3. Telemetry Generation
- Creates structured data streams containing:
  - UAV GPS location
  - Altitude and airspeed
  - Battery level and signal strength
  - System status (normal or degraded)
- Adds realistic variability such as noise, delay, or signal jitter

### 4. Data Streaming
- Publishes telemetry data in real time using a WebSocket-based SignalR hub
- Enables live updates to be consumed by:
  - Windows desktop control panel (WPF)
  - Web mission dashboard (React + Redux)
  - Android mobile app (.NET MAUI)

### 5. Database Logging
- Periodically logs telemetry snapshots into a local SQLite database
- Provides historical data for analysis, debugging, or mission replay

### 6. Error & Alert Simulation
- Injects simulated system conditions:
  - Battery drain or low power warnings
  - Signal degradation or dropouts
  - Return-to-Base behavior on failure
- Supports testing of alert detection mechanisms in other components

---

## System Interactions

- **Reads:** Mission data and waypoints from the database
- **Writes:** Telemetry data to the telemetry log database table
- **Pushes:** Real-time telemetry to other modules via SignalR
- **Responds:** To start/stop simulation commands from FitNesse test suite or UI triggers

---

## Integration with FitNesse

- Exposes simulation control hooks to FitNesse for automated acceptance testing
- Supports test cases that verify telemetry structure, frequency, value ranges, and mission behavior
- Provides repeatable test scenarios to validate mission execution logic under various conditions

---

## Development Goals

- Modular and testable design
- Real-time responsiveness with accurate simulation pacing
- Support for fault injection and recovery logic
- Alignment with Agile workflow and continuous integration pipelines

---

## Future Enhancements

- Replay missions using historical telemetry data
- Export telemetry to CSV for offline analysis
- Integrate 3D flight path visualization using UAV model
- Simulate multiple UAVs in parallel for swarm scenarios

---

## Summary

The FalconOps Telemetry Simulator is a mission-critical component designed to mirror realistic UAV behaviors and enable thorough validation of system-wide interactions. It provides both the operational heartbeat of the simulation and the foundation for robust testing and visualization of UAV operations.

