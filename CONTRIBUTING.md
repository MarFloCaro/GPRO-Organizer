````markdown
# Contributing to GPRO Organizer

First of all, thank you for your interest in contributing to GPRO Organizer.

This project is currently in a transitional stage:
- preserving and maintaining a legacy WinForms application
- improving release and distribution infrastructure
- gradually modernizing the codebase
- preparing a long-term migration toward API-driven architecture

Contributions, fixes and ideas are welcome.

---

# Project Goals

Current priorities include:

- maintaining application usability
- fixing critical bugs
- improving stability
- improving release automation
- reducing scraping dependency
- transitioning toward official API usage
- modernizing architecture incrementally

---

# Development Environment

Current legacy stack:

- C#
- .NET Framework
- WinForms
- Visual Studio solution (`Go.sln`)

The application currently targets Windows desktop usage.

---

# Repository Workflow

## Main branch

The `main` branch is considered the stable branch.

Direct pushes should be limited to maintainers and collaborators.

---

# Release Process

Releases are generated automatically through GitHub Actions.

Releases are triggered through Git tags.

Example:

```bash
git tag v3.2.22
git push origin v3.2.22
```

The workflow will:
- build the application
- package the release ZIP
- publish a GitHub Release automatically

---

# Versioning

The application version is currently defined in:

```text
AssemblyInfo.cs
```

Example:

```csharp
[assembly: AssemblyFileVersion("3.2.22")]
```

Please keep version information updated before creating a release tag.

---

# Pull Requests

When submitting a pull request:

- keep changes focused and reasonably scoped
- describe the purpose of the change clearly
- avoid unrelated formatting-only changes
- test the application locally if possible
- document important behavioral changes

---

# Coding Guidelines

Because this is a legacy project:

- prioritize readability over cleverness
- avoid introducing unnecessary dependencies
- avoid large architectural rewrites in isolated PRs
- prefer incremental modernization

For new code:
- use clear naming
- minimize duplicated logic
- isolate parsing/networking concerns when possible

---

# Scraping vs API

Historically, the application relied heavily on scraping.

The long-term direction is to transition toward official API usage whenever feasible.

New contributions should avoid introducing additional scraping dependencies unless absolutely necessary.

---

# Data Files

The application currently uses local `.dat` files for persistence.

Future versions may migrate toward more transparent and portable formats such as JSON.

Contributors working on persistence improvements should prioritize:
- backward compatibility
- migration safety
- data portability

---

# Issues

Bug reports are welcome.

When possible, include:
- application version
- operating system
- reproduction steps
- screenshots/logs/errors

---

# Community

This project exists thanks to the GPRO community and contributors who help keep the tool alive and evolving.

Thank you for contributing.
````
