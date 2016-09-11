public class CircularBuffer<T>
{
	private T[] _buffer;
	private int _start;
	private int _end;

	public CircularBuffer()
		: this(capacity : 10)
		{

		}

	public CircularBuffer(int capacity)
		{
			_buffer = new T[capacity + 1];
			_start = 0;
			_end = 0;
		}

	public void Write(T value)
		{
			_buffer[_end] = value;
			_end = (_end+1)
		}
}