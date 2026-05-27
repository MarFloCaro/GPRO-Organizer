# GPRO Organizer

![Release](https://img.shields.io/github/v/release/MarFloCaro/GPRO-Organizer?style=for-the-badge)
![Downloads](https://img.shields.io/github/downloads/MarFloCaro/GPRO-Organizer/latest/total?style=for-the-badge&color=purple)
![Last Commit](https://img.shields.io/github/last-commit/MarFloCaro/GPRO-Organizer?style=for-the-badge)

GPRO Organizer is a community-maintained desktop companion tool for [GPRO](https://gpro.net) players.

This application helps managers collect, store and analyze game data locally on their own computer.

> [!IMPORTANT]
> This is a legacy application currently maintained and distributed in portable format.
> No installer is required.

---

## Download

Releases are available at:

[GPRO Organizer Releases](https://github.com/MarFloCaro/GPRO-Organizer/releases)

Download the latest ZIP file from the **Assets** section of the most recent release.

---

## Installation

### New users

1. Download the latest release ZIP
2. Create a folder where you want to keep the application
3. Extract the ZIP contents into that folder
4. Run:

```text id="3m0jpk"
go.exe
```

---

### Existing users

If you already use GPRO Organizer and already have a `go.dat` file:

1. Download the latest release ZIP
2. Extract the new files into your existing application folder
3. Replace existing files when prompted
    * If your `tracks.dat` file is newer than the one on the relase, ´do not replace´. 

Your local data should remain preserved.

---

## First Startup

The releases after 4.1 come with a `tracks.dat` file included. In the eventuality that GPRO gets a new track added — tracks data must be updated manually.

After opening the application:

### Step 1 — Update tracks (optional)

Navigate to:

```text id="p2u2k6"
Tools -> Update tracks
```

![Update Tracks](docs/screenshots/update-tracks.jpg)

The application will generate the required fresher `tracks.dat` file.

When the update finishes, the application will request a restart.

Close and reopen the application.

---

### Step 2 — Download your game data

After restarting:

Navigate to:

```text id="10m6m7"
Online -> Get All Data
```
![Get All Data](docs/screenshots/get-data.jpg)

---

### Step 3 — Save your data

After data download completes:

Navigate to:

```text id="tksr6q"
File -> Save
```

![Save](docs/screenshots/save.jpg)

If this is your first use, the application will generate the `go.dat` file after saving, which stores your local data.

---

## Recommended Setup

For easier access, it is recommended to:

* create a desktop shortcut
* pin the application to the Start Menu
* or pin it to the taskbar

---

## Notes

* This application stores data locally on your computer.
* No cloud synchronization is performed.
* The application currently relies on legacy architecture and is under gradual modernization.
* Future versions are expected to transition away from scraping-based communication toward the official API.

---

## Project Status

This project is community maintained and currently focused on:

* preserving functionality
* improving distribution
* fixing critical issues
* modernizing infrastructure
* preparing future API-based evolution

---

## Maintainers

<table>
  <tr>
    <td align="center" width="50%">
      <a href="https://github.com/Krumiasty">
        <img src="https://github.com/Krumiasty.png?size=100" width="100" alt="Rafał Celejewski"><br>
        <strong>Rafał Celejewski</strong>
      </a>
      <br><br>
      <a href="https://gpro.net/ManagerProfile.asp?IDM=47036">
        GPRO Profile
      </a>
      <br>
      Ongoing Maintenance
    </td>
    <td align="center" width="50%">
      <a href="https://github.com/MarFloCaro">
        <img src="https://github.com/MarFloCaro.png?size=100" width="100" alt="Flo Caro"><br>
        <strong>Flo Caro</strong>
      </a>
      <br><br>
      <a href="https://gpro.net/ManagerProfile.asp?IDM=232105">
        GPRO Profile
      </a>
      <br>
      Infrastructure & Releases
    </td>
  </tr>
</table>

---

## License

See the repository license file for details.