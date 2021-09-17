using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayingScript : MonoBehaviour 
{
	public VideoClip[] m_VideoClips;
	public int videoClipIndex;
	public VideoPlayer vp;

	private VideoPlayer m_VideoPlayer;


	void Start ()
	{
		m_VideoPlayer = vp;
		//		m_VideoPlayer = GetComponent<VideoPlayer> ();
		m_VideoPlayer.clip = m_VideoClips [videoClipIndex];
	}


	public void NextVideoFunction()
	{
		if 	(videoClipIndex < m_VideoClips.Length - 1) 
		{
			videoClipIndex++;
		}

		m_VideoPlayer.clip = m_VideoClips [videoClipIndex];
		m_VideoPlayer.Play ();
	}

	public void PreviousVideoFunction()
	{

		if (videoClipIndex > 0 ) 
		{
			videoClipIndex--;
		}

		m_VideoPlayer.clip = m_VideoClips [videoClipIndex];
		m_VideoPlayer.Play ();
	}
}
