using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nah
{
	/// <summary>
	/// Базовый класс всех объектов на сцене
	/// </summary>
	public abstract class BaseObjectScene : MonoBehaviour
	{
		private int layer;
		private Color color;
		private Material material;
		private Transform myTransform;
		private Vector3 position;
		private Quaternion rotation;
		private Vector3 scale;
		private GameObject instanceObject;
		private Rigidbody _rigidbody;
		private string _name;
		private bool isVisible;

		protected int Layer
		{
			get { return layer; }
			set
			{
				layer = value;
				if (instanceObject != null)
				{
					instanceObject.layer = layer;
				}
				if (instanceObject != null)
				{
					AskLayer(GetTransform, value);
				}
			}
		}

		protected Color Color
		{
			get
			{
				return color;
			}

			set
			{
				color = value;
			}
		}

		protected Material Material
		{
			get
			{
				return material;
			}

			set
			{
				material = value;
			}
		}

		protected Transform MyTransform
		{
			get
			{
				return myTransform;
			}

			set
			{
				myTransform = value;
			}
		}

		protected Vector3 Position
		{
			get
			{
				return position;
			}

			set
			{
				position = value;
			}
		}

		protected Quaternion Rotation
		{
			get
			{
				return rotation;
			}

			set
			{
				rotation = value;
			}
		}

		protected Vector3 Scale
		{
			get
			{
				return scale;
			}

			set
			{
				scale = value;
			}
		}

		protected GameObject InstanceObject
		{
			get
			{
				return instanceObject;
			}

			set
			{
				instanceObject = value;
			}
		}

		protected Rigidbody Rigidbody
		{
			get
			{
				return _rigidbody;
			}

			set
			{
				_rigidbody = value;
			}
		}

		protected string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				InstanceObject.name = _name;
			}
		}

		protected bool IsVisible
		{
			get
			{
				return isVisible;
			}

			set
			{
				isVisible = value;
			}
		}

		protected virtual void Awake()
		{
			InstanceObject = gameObject;
			Name = InstanceObject.name;
			if (GetComponent<Renderer>())
			{
				Material = GetComponent<Renderer>().material;
			}
			Rigidbody = InstanceObject.GetComponent<Rigidbody>();
			MyTransform = InstanceObject.transform;
		}


		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}
