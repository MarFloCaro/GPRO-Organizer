# Contributing to GPRO Organizer

First of all, thank you for your interest in contributing to GPRO Organizer.

This project is currently in a transitional stage:
- preserving and maintaining a legacy WinForms application
- improving release and distribution infrastructure
- gradually modernizing the codebase
- preparing a long-term migration toward API-driven architecture

Contributions, fixes and ideas are welcome.

---

## Project Goals

Current priorities include:

- maintaining application usability
- fixing critical bugs
- improving stability
- improving release automation
- reducing scraping dependency
- transitioning toward official API usage
- modernizing architecture incrementally

---

## Development Environment

Current legacy stack:

- C#
- .NET Framework
- WinForms
- Visual Studio solution (`Go.sln`)

The application currently targets Windows desktop usage.

---

## Repository Workflow

### Main branch

The `main` branch is considered the stable branch.

Direct pushes should be limited to maintainers and collaborators.

---

## Release Process

Releases are generated automatically through GitHub Actions.

Releases are triggered through Git tags.

Example (considering a workflow that requires Pull Requests, and the working branch is develop):

1. Checkout the develop branch and ensure code is upto date

```bash
git checkout develop
git pull origin develop
```

2. Introduce the changes to the code; do not miss to update `AssemblyInfo.cs`

```c#
[assembly: AssemblyFileVersion("4.0.0")]
[assembly: AssemblyVersion("4.0.0.32438")]
```

3. Commit Changes

```bash
git add .
git commit -m "Release v4.0.0"
```

4. Push `develop` (or working branch)

```bash
git push origin develop
```

5. Open PR (Pull Request)

6. Merge to main

7. Update `main` locally

```bash
git checkout main
git pull origin main
```

8. Create Release Tag

```bash
git tag v4.0.0
```

9. Push the tag

```bash
git push origin v4.0.0 # same as tag above
```

OR:

```bash
git push origin --tags
```

The workflow will:
- build the application
- package the release ZIP
- publish a GitHub Release automatically

---

## Versioning

The application version is currently defined in:

```text
AssemblyInfo.cs
```

Example:

```csharp
[assembly: AssemblyFileVersion("4.0.0")]
```

Please keep version information updated before creating a release tag.

---

## Pull Requests

When submitting a pull request:

- keep changes focused and reasonably scoped
- describe the purpose of the change clearly
- avoid unrelated formatting-only changes
- test the application locally if possible
- document important behavioral changes

---

## Coding Guidelines

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

## Scraping vs API

Historically, the application relied heavily on scraping.

The long-term direction is to transition toward official API usage whenever feasible.

New contributions should avoid introducing additional scraping dependencies unless absolutely necessary.

---

## Data Files

The application currently uses local `.dat` files for persistence.

Future versions may migrate toward more transparent and portable formats such as JSON.

Contributors working on persistence improvements should prioritize:
- backward compatibility
- migration safety
- data portability

---

## Issues

Bug reports are welcome.

When possible, include:
- application version
- operating system
- reproduction steps
- screenshots/logs/errors

---

## Community

This project exists thanks to the GPRO community and contributors who help keep the tool alive and evolving.

Thank you for contributing.

