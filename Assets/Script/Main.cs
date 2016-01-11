using System.Collections;
using UnityEngine;

public class Main : MonoBehaviour {

	void Start() {

		System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

		sw.Reset();
		sw.Start();

		for (int i = 0; i < 100000; i++) {
			GameObject a = Instantiate(Resources.Load<GameObject>("A"));
			a.AddComponent<TestA>();
		}

		sw.Stop();


		print("1:"+sw.ElapsedMilliseconds);

		sw.Reset();
		sw.Start();

		for (int i = 0; i < 100000; i++) {
			GameObject a = Instantiate(Resources.Load<GameObject>("B"));
		}

		sw.Stop();
		print("2:" + sw.ElapsedMilliseconds);


	}
}
