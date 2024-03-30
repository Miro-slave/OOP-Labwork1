using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Components.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab3;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
public abstract class ShipBase : IDamageable, IFuelConsumer
{
    private readonly double _mass;
    private readonly HullBase _hull;
    private readonly DeflectorBase? _deflector;
    private readonly IEnumerable<IEngine> _engines;
    private readonly AntiNeutrinoEmitter? _antiNeutrinoEmitter;
    private bool _isDestroyedFlag;
    private bool _isCrewDeadFlag;
    private bool _isShipLostFlag;

    protected ShipBase(
        double mass,
        HullBase hull,
        DeflectorBase? deflector,
        IEnumerable<IEngine> engines,
        AntiNeutrinoEmitter? antiNeutrinoEmitter = null)
    {
        Guard.NotNull(hull, nameof(hull));
        Guard.NotNull(engines, nameof(engines));
        _mass = mass;
        _hull = hull;
        _deflector = deflector;
        _engines = engines;
        _antiNeutrinoEmitter = antiNeutrinoEmitter;
        _isDestroyedFlag = hull.IsDestroyedFlag;
        _isCrewDeadFlag = false;
        _isShipLostFlag = false;
    }

    public bool IsDestroyedFlag { get { return _isDestroyedFlag; } }
    public bool IsFunctional { get { return !_isDestroyedFlag && !_isCrewDeadFlag && !_isShipLostFlag; } }
    public bool HasPhotonDeflector { get { return _deflector is PhotonDeflector; } }
    public bool HasAntiNeutrinoEmitter { get { return _antiNeutrinoEmitter is not null; } }
    public void PassDamage(IDamager damager)
    {
        if (damager is SpaceWhale && HasAntiNeutrinoEmitter)
        {
            return;
        }

        if (damager is AntimatterFlash)
        {
            _isDestroyedFlag = !HasPhotonDeflector;
            return;
        }

        if (_deflector is not null)
        {
            _deflector.PassDamage(damager);
            if (!_deflector.IsDestroyedFlag)
            {
                return;
            }
        }

        if (!_hull.IsDestroyedFlag)
        {
            _hull.PassDamage(damager);
            _isDestroyedFlag = _hull.IsDestroyedFlag;
        }
        else
        {
            _isDestroyedFlag = true;
        }
    }

    public double? TryCountFuelConsumingPrice(IRouteSegment routeSegment, FuelPrice fuelPrice)
    {
        Guard.NotNull(fuelPrice, nameof(fuelPrice));
        Guard.NotNull(routeSegment, nameof(routeSegment));

        double? minimalSegmentPassPrice = null;
        foreach (IEngine engine in _engines)
        {
            double? fuelAmount = engine.TryCountFuelConsuming(routeSegment, _mass);

            if (!fuelAmount.HasValue)
            {
                continue;
            }

            double segmentPassPrice;
            if (engine.FuelType is EngineFuelType.ActivePlasma)
            {
                segmentPassPrice = (double)fuelAmount * fuelPrice.ActivePlasmaPrice;
            }
            else if (engine.FuelType is EngineFuelType.GravitonMatter)
            {
                segmentPassPrice = (double)fuelAmount * fuelPrice.GravitonMatterPrice;
            }
            else
            {
                throw new ArgumentException("unknown route segment type");
            }

            if (minimalSegmentPassPrice is null)
            {
                minimalSegmentPassPrice = segmentPassPrice;
            }
            else
            {
                minimalSegmentPassPrice = Math.Min((double)minimalSegmentPassPrice, segmentPassPrice);
            }
        }

        return minimalSegmentPassPrice;
    }

    public PassResult TryPassSegment(IRouteSegment routeSegment, FuelPrice fuelPrice)
    {
        Guard.NotNull(routeSegment, nameof(routeSegment));
        foreach (ObstacleBase obstacle in routeSegment.Obstacles)
        {
            PassDamage(obstacle);
        }

        if (_isDestroyedFlag)
        {
            return new PassResult.ShipIsDestroyed();
        }
        else if (_isCrewDeadFlag)
        {
            return new PassResult.CrewIsDead();
        }

        double? minimalSegmentPassPrice = TryCountFuelConsumingPrice(routeSegment, fuelPrice);

        if (minimalSegmentPassPrice.HasValue)
        {
            return new PassResult.Success((double)minimalSegmentPassPrice);
        }
        else
        {
            return new PassResult.ShipIsLost();
        }
    }
}
