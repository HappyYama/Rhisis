
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Rhisis.Protocol;

namespace Rhisis.Game.TaskbarPlayer;

public class TaskbarContainer<TObject> : IEnumerable<TObject>, IPacketSerializer 
    where TObject : class, IPacketSerializer
{
    private readonly TObject[] _objects;

    /// <summary>
    /// Gets the taskbar capacity.
    /// </summary>
    public int Capacity { get; }

    /// <summary>
    /// Get the number of objects in the taskbar.
    /// </summary>
    public int Count => _objects.Count(x => x is not null);

    public TaskbarContainer(int capacity)
    {
        _objects = new TObject[capacity];
        Capacity = capacity;
    }

    /// <summary>
    /// Adds an object at a given slot.
    /// </summary>
    /// <param name="object">Object to add.</param>
    /// <param name="slotIndex">Slot.</param>
    /// <returns>True if the object is added; false otherwise.</returns>
    public bool Add(TObject @object, int slotIndex) => SetAt(slotIndex, @object);

    /// <summary>
    /// Removes an object at the given slot.
    /// </summary>
    /// <param name="slotIndex">Slot index.</param>
    /// <returns>True if the object has been removed; false otherwise.</returns>
    public bool Remove(int slotIndex) => SetAt(slotIndex, null);

    public void Serialize(FFPacket packet)
    {
        packet.WriteInt32(Count);

        for (int i = 0; i < Capacity; i++)
        {
            if (_objects[i] is not null)
            {
                _objects[i].Serialize(packet);
            }
        }
    }

    private bool SetAt(int slotIndex, TObject @object)
    {
        if (slotIndex < 0 || slotIndex >= Capacity)
        {
            return false;
        }

        _objects[slotIndex] = @object;

        return true;
    }

    public IEnumerator<TObject> GetEnumerator() => (IEnumerator<TObject>)_objects.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _objects.GetEnumerator();
}
