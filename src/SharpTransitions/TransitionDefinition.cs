using SharpTransitions.Methods;
using System;
using System.Collections.Generic;

namespace SharpTransitions
{
	public class TransitionDefinition
	{
		private readonly List<TargetPropertyDestination> _targetPropertyDestinations = new List<TargetPropertyDestination>();

		public TransitionDefinition With(object target, string propertyName, object destinationValue)
		{
			_targetPropertyDestinations.Add(new TargetPropertyDestination 
			{
				Target = target,
				PropertyName = propertyName,
				DestinationValue = destinationValue
			});

			return this;
		}

		public void Accelerate(TimeSpan transitionTime)
		{
			BuildAndRun(new Acceleration((int)transitionTime.TotalMilliseconds));
		}

		public void Bounce(TimeSpan transitionTime)
		{
			BuildAndRun(new Bounce((int)transitionTime.TotalMilliseconds));
		}

		public void CriticalDamp(TimeSpan transitionTime)
		{
			BuildAndRun(new CriticalDamping((int)transitionTime.TotalMilliseconds));
		}

		public void Decelerate(TimeSpan transitionTime)
		{
			BuildAndRun(new Deceleration((int)transitionTime.TotalMilliseconds));
		}

		public void EaseInEaseOut(TimeSpan transitionTime)
		{
			BuildAndRun(new EaseInEaseOut((int)transitionTime.TotalMilliseconds));
		}

		public void Flash(int numberOfFlashes, TimeSpan transitionTime)
		{
			BuildAndRun(new Flash(numberOfFlashes, (int)transitionTime.TotalMilliseconds));
		}

		public void Linear(TimeSpan transitionTime)
		{
			BuildAndRun(new Linear((int)transitionTime.TotalMilliseconds));
		}

		public void ThrowAndCatch(TimeSpan transitionTime)
		{
			BuildAndRun(new ThrowAndCatch((int)transitionTime.TotalMilliseconds));
		}

		public void UserDefined(IList<TransitionElement> elements, TimeSpan transitionTime)
		{
			BuildAndRun(new UserDefined(elements, (int)transitionTime.TotalMilliseconds));
		}

		private void BuildAndRun(IMethod method)
		{
			Build(method).Run();
		}

		public Transition Build(IMethod method)
		{
			var transition = new Transition(method);

			foreach (var item in _targetPropertyDestinations)
				transition.Add(item.Target, item.PropertyName, item.DestinationValue);

			return transition;
		}

		internal class TargetPropertyDestination
		{ 
			public object Target { get; set; }

			public string PropertyName { get; set; }

			public object DestinationValue { get; set; }
		}
	}
}
