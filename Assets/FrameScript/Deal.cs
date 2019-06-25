using System.Collections.Generic;

public abstract class Deal
{
    protected List<Data> requireData = null;
    protected Deal() {
        G1Manager.AddDeal(this);
    }

    public void SetRequire(List<Data> datas = null) {
        requireData = datas;
    }
    public void SetRequire(Data data) {
        requireData = new List<Data> { data };
    }
    public T GetRequire<T>() where T : Data {
        foreach (Data i in requireData) {
            if (i.GetDataType() == typeof(T)) {
                return (T)i;
            }
        }
        return default;
    }

    public T[] GetRequires<T>() where T : Data {
        List<T> temp = new List<T>();
        foreach (Data i in requireData) {
            if (i.GetDataType() == typeof(T)) {
                temp.Add((T)i);
            }
        }
        return temp.ToArray();
    }
    public abstract void Execute();
}
