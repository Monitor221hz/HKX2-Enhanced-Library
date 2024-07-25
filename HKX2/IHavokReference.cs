namespace HKX2E;

internal interface IHavokReference
{
	void Update<T>(T value) where T : IHavokObject;
}