﻿using System.Collections.Generic;

namespace Rhisis.Game.Battle.Projectiles;

public class ProjectileList
{
    private readonly Dictionary<int, Projectile> _projectiles = new();
    private int _projectileCounter = 1;

    /// <summary>
    /// Gets the number of active projectiles.
    /// </summary>
    public int Count => _projectiles.Count;

    /// <summary>
    /// Adds a new projectile.
    /// </summary>
    /// <param name="projectile">Projectile information.</param>
    /// <returns>Projectile id.</returns>
    public int Add(Projectile projectile)
    {
        int projectileId = _projectileCounter++;

        _projectiles.Add(projectileId, projectile);

        return projectileId;
    }

    /// <summary>
    /// Removes the projectile identified by the given value.
    /// </summary>
    /// <param name="projectileId">Projectile id to remove.</param>
    public void Remove(int projectileId)
    {
        _projectiles.Remove(projectileId);
    }

    /// <summary>
    /// Gets the projectile identified by the given id.
    /// </summary>
    /// <param name="projectileId">Projectile id.</param>
    /// <returns>Projectile if found; null otherwise.</returns>
    public Projectile Get(int projectileId) => _projectiles.GetValueOrDefault(projectileId);

    /// <summary>
    /// Clears the projectiles.
    /// </summary>
    public void Clear()
    {
        _projectiles.Clear();
        _projectileCounter = 1;
    }
}