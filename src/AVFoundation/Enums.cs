// Copyright 2009, Novell, Inc.
// Copyright 2010, Novell, Inc.
// Copyright 2011, 2012, 2014 Xamarin Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//
using System;
using System.ComponentModel;
using XamCore.Foundation;
using XamCore.ObjCRuntime;
using System.Runtime.InteropServices;

namespace XamCore.AVFoundation {

	[Native]
	// NSInteger - AVAudioSettings.h
	public enum AVAudioQuality : nint {
		Min = 0,
		Low = 0x20,
		Medium = 0x40,
		High = 0x60,
		Max = 0x7F
	}

	[iOS (4,0)]
	[Native]
	// NSInteger - AVAssetExportSession.h
	public enum AVAssetExportSessionStatus : nint {
		Unknown,
		Waiting,
		Exporting,
		Completed,
		Failed,
		Cancelled
	}

	[iOS (4,0)]
	[Native]
	// NSInteger - AVAssetReader.h
	public enum AVAssetReaderStatus : nint {
		Unknown = 0,
		Reading,
		Completed,
		Failed,
		Cancelled,
	}

	[iOS (4,1)]
	[Native]
	// NSInteger - AVAssetWriter.h
	public enum AVAssetWriterStatus : nint {
		Unknown = 0,
		Writing,
		Completed,
		Failed,
		Cancelled,
	}

	[NoTV]
	[iOS (4,0)]
	[Native]
	// NSInteger - AVCaptureSession.h
	public enum AVCaptureVideoOrientation : nint {
		Portrait = 1,
		PortraitUpsideDown,
		LandscapeRight,
		LandscapeLeft,
	}

	[NoTV]
	[iOS (4,0)]
	[Native]
	// NSInteger - AVCaptureDevice.h
	public enum AVCaptureFlashMode : nint {
		Off, On, Auto
	}

	[NoTV]
	[iOS (4,0)]
	[Native]
	// NSInteger - AVCaptureDevice.h
	public enum AVCaptureTorchMode : nint {
		Off, On, Auto
	}

	[NoTV]
	[iOS (4,0)]
	[Native]
	// NSInteger - AVCaptureDevice.h
	public enum AVCaptureFocusMode : nint {
		Locked, AutoFocus, ContinuousAutoFocus,

#if !XAMCORE_2_0
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Obsolete ("use Locked instead")]
		ModeLocked = Locked,
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Obsolete ("use AutoFocus instead")]
		ModeAutoFocus = AutoFocus,
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Obsolete ("use ContinuousAutoFocus instead")]
		ModeContinuousAutoFocus = ContinuousAutoFocus
#endif
	}

	[NoTV]
	[iOS (4,0)]
	[Native]
	// NSInteger - AVCaptureDevice.h
	public enum AVCaptureDevicePosition : nint {
		Unspecified = 0,
		Back = 1,
		Front = 2
	}
	
	[NoTV]
	[iOS (4,0)]
	[Native]
	// NSInteger - AVCaptureDevice.h
	public enum AVCaptureExposureMode : nint {
		Locked, AutoExpose, ContinuousAutoExposure, [iOS (8,0)] Custom
	}

	[NoTV]
	[iOS (4,0)]
	[Native]
	// NSInteger - AVCaptureDevice.h
	public enum AVCaptureWhiteBalanceMode : nint {
		Locked, AutoWhiteBalance, ContinuousAutoWhiteBalance
	}

	[Flags]
	[NoTV]
	[iOS (4,0)]
	[Native]
	[Availability (Deprecated = Platform.iOS_6_0)]
	// NSUInteger - AVAudioSession.h
	public enum AVAudioSessionInterruptionFlags : nuint_compat_int {
		ShouldResume = 1
	}

	// Populated in NSError.Code, an NSInteger
	// anonymous enum - AVError.h
	[Native]
	public enum AVError : nint {
		Unknown = -11800,
		OutOfMemory = -11801,
		SessionNotRunning = -11803,
		DeviceAlreadyUsedByAnotherSession = -11804,
		NoDataCaptured = -11805,
		SessionConfigurationChanged = -11806,
		DiskFull = -11807,
		DeviceWasDisconnected = -11808,
		MediaChanged = -11809,
		MaximumDurationReached = -11810,
		MaximumFileSizeReached = -11811,
		MediaDiscontinuity = -11812,
		MaximumNumberOfSamplesForFileFormatReached = -11813,
		DeviceNotConnected = -11814,
		DeviceInUseByAnotherApplication = -11815,
		DeviceLockedForConfigurationByAnotherProcess = -11817,
		SessionWasInterrupted = -11818,
		MediaServicesWereReset = -11819,
		ExportFailed = -11820,
		DecodeFailed = -11821,
		InvalidSourceMedia = - 11822,
		FileAlreadyExists = -11823,
		CompositionTrackSegmentsNotContiguous = -11824,
		InvalidCompositionTrackSegmentDuration = -11825,
		InvalidCompositionTrackSegmentSourceStartTime= -11826,
		InvalidCompositionTrackSegmentSourceDuration = -11827,
		FormatNotRecognized = -11828,
		FailedToParse = -11829, // Should have been FileFailedToParse
		MaximumStillImageCaptureRequestsExceeded = 11830,
		ContentIsProtected = -11831,
		NoImageAtTime = -11832,
		DecoderNotFound = -11833,
		EncoderNotFound = -11834,
		ContentIsNotAuthorized = -11835,
		ApplicationIsNotAuthorized = -11836,
		DeviceIsNotAvailableInBackground = -11837,
		OperationNotSupportedForAsset = -11838,
		DecoderTemporarilyUnavailable = -11839,
		EncoderTemporarilyUnavailable = -11840,
		InvalidVideoComposition = -11841,
		//[iOS (5,1)]
		ReferenceForbiddenByReferencePolicy = -11842,
		InvalidOutputURLPathExtension = -11843,
		ScreenCaptureFailed = -11844,
		DisplayWasDisabled = -11845,
		TorchLevelUnavailable = -11846,
		OperationInterrupted = -11847,
		IncompatibleAsset = -11848,
		FailedToLoadMediaData = -11849,
		ServerIncorrectlyConfigured = -11850,
		ApplicationIsNotAuthorizedToUseDevice = 11852,
			
		FailedToParse2 = -11853,
		FileTypeDoesNotSupportSampleReferences = -11854,
		UndecodableMediaData = -11855,

		AirPlayControllerRequiresInternet = -11856,
		AirPlayReceiverRequiresInternet = -11857,

		[iOS (9,0), Mac (10,11)]
		VideoCompositorFailed = -11858,

#if !MONOMAC
		[iOS (9,0)]
		RecordingAlreadyInProgress = -11859
#endif
	}

	[iOS (4,0)]
	[Native]
	// NSInteger - AVPlayer.h
	public enum AVPlayerActionAtItemEnd : nint {
		Advance,
		Pause,
		None
	}

	[iOS (4,0)]
	[Native]
	// NSInteger - AVPlayerItem.h
	public enum AVPlayerItemStatus : nint {
		Unknown, ReadyToPlay, Failed
	}

	[NoTV]
	[Flags]
	[iOS (4,0)]
	[Native]
	[Availability (Deprecated = Platform.iOS_6_0)]
	// declared as AVAudioSessionSetActiveOptions (NSUInteger) - AVAudioSession.h
	public enum AVAudioSessionFlags : nuint_compat_int {
		NotifyOthersOnDeactivation = 1
	}

	[iOS (4,0)]
	[Native]
	// NSInteger - AVAsynchronousKeyValueLoading.h
	public enum AVKeyValueStatus : nint {
		Unknown, Loading, Loaded, Failed, Cancelled
	}

	[iOS (4,0)]
	[Native]
	// NSInteger - AVPlayer.h
	public enum AVPlayerStatus : nint {
		Unknown,
		ReadyToPlay,
		Failed
	}

	[Native]
	// NSUInteger - AVAsset.h
	public enum AVAssetReferenceRestrictions : nuint_compat_int {
		ForbidNone = 0,
		ForbidRemoteReferenceToLocal = (1 << 0),
		ForbidLocalReferenceToRemote = (1 << 1),
		ForbidCrossSiteReference     = (1 << 2),
		ForbidLocalReferenceToLocal  = (1 << 3),
		ForbidAll = 0xFFFF,
	}

	[Native]
	// NSInteger - AVAssetImageGenerator.h
	public enum AVAssetImageGeneratorResult : nint {
		Succeeded, Failed, Cancelled
	}

#if !XAMCORE_3_0 || MONOMAC
	[NoTV]
	[Mac (10,7)] // N/A in iOS
	[Native]
	// NSInteger - AVCaptureDevice.h
	public enum AVCaptureDeviceTransportControlsPlaybackMode : nint {
		NotPlaying, Playing
	}

	[NoTV]
	[Mac (10,7)] // N/A in iOS
	[Native]
	// NSInteger - AVCaptureSession.h
	public enum AVVideoFieldMode : nint {
		Both, TopOnly, BottomOnly, Deinterlace
	}
#endif

	[Flags]
	[Native]
	// NSUInteger - AVAudioSession.h
	public enum AVAudioSessionInterruptionOptions : nuint_compat_int {
		ShouldResume = 1
	}

	[Flags]
	[Native]
	// NSUInteger - AVAudioSession.h
	public enum AVAudioSessionSetActiveOptions : nuint_compat_int {
		NotifyOthersOnDeactivation = 1
	}

	[Native]
	// NSUInteger - AVAudioSession.h
	public enum AVAudioSessionPortOverride : nuint_compat_int {
		None = 0,
		[NoTV]
		Speaker = 0x73706b72 // 'spkr'
	}

	[Native]
	// NSUInteger - AVAudioSession.h
	public enum AVAudioSessionRouteChangeReason : nuint_compat_int {
		Unknown,
		NewDeviceAvailable,
		OldDeviceUnavailable,
		CategoryChange,
		Override,
		WakeFromSleep = 6,
		NoSuitableRouteForCategory = 7,
		RouteConfigurationChange = 8
	}

	[Flags]
	[Native]
	// NSUInteger - AVAudioSession.h
	public enum AVAudioSessionCategoryOptions : nuint_compat_int {
		MixWithOthers = 1,
		DuckOthers = 2,
		[NoTV]
		AllowBluetooth = 4,
		[NoTV]
		DefaultToSpeaker = 8,

		[iOS (9,0), Mac (10,11)]
		InterruptSpokenAudioAndMixWithOthers = 17
	}

	[Native]
	// NSUInteger - AVAudioSession.h
	public enum AVAudioSessionInterruptionType : nuint_compat_int  {
		Ended, Began
	}

	[Native]
	// NSInteger - AVAudioSession.h
	public enum AVAudioSessionErrorCode : nint {
		None = 0,
		MediaServicesFailed = 0x6D737276,
		IsBusy = 0x21616374,
		IncompatibleCategory = 0x21636174,
		CannotInterruptOthers = 0x21696e74,
		MissingEntitlement = 0x656e743f,
		SiriIsRecording = 0x73697269,
		CannotStartPlaying = 0x21706c61,
		[Availability (Introduced = Platform.iOS_7_0)]
		CannotStartRecording = 0x21726563,
		BadParam = -50,
		Unspecified = 0x77686174,
		InsufficientPriority = 0x21707269,
		[iOS (9,0)]
		CodeResourceNotAvailable = 0x21726573
	}

	[NoTV]
	[Native]
	// NSInteger - AVCaptureDevice.h
	public enum AVCaptureAutoFocusRangeRestriction : nint {
		None = 0,
		Near = 1,
		Far = 2
	}

	// Convenience enum for native strings (defined in AVAudioSettings.h)
	public enum AVAudioBitRateStrategy : int {
		Constant,
		LongTermAverage,
		VariableConstrained,
		Variable
	}

	// Convenience enum for native strings (defined in AVAudioSettings.h)
	public enum AVSampleRateConverterAlgorithm : int {
		Normal,
		Mastering
	}

	[NoTV]
	[Native]
	// NSInteger - AVCaptureDevice.h
	public enum AVAuthorizationStatus : nint {
		NotDetermined, Restricted, Denied, Authorized
	}

	[iOS (7,0)]
	[Native]
	// NSInteger - AVSpeechSynthesis.h
	public enum AVSpeechBoundary : nint {
		Immediate,
		Word
	}

	[iOS (8,0)]
	[Native]
	public enum AVAudioCommonFormat : nuint {
		Other = 0,
		PCMFloat32 = 1,
		PCMFloat64 = 2,
		PCMInt16 = 3,
		PCMInt32 = 4
	}

	[Native]
	public enum AVAudio3DMixingRenderingAlgorithm : nint {
		EqualPowerPanning = 0,
		SphericalHead = 1,
		HRTF = 2,
		SoundField = 3,
		StereoPassThrough = 5
	}

	[NoTV]
	[Native]
	public enum AVAudioSessionRecordPermission : nuint {
		Undetermined = 1970168948 /*'undt'*/,
		Denied = 1684369017 /*'deny'*/,
		Granted = 1735552628 /*'grnt'*/
	}

	[Native]
	public enum AVAudioSessionSilenceSecondaryAudioHintType : nuint {
		Begin = 1,
		End = 0
	}

	[Flags]
	[Native]
	public enum AVAudioPlayerNodeBufferOptions : nuint {
		Loops            = 0x01,
		Interrupts       = 0x02,
		InterruptsAtLoop = 0x04
	}

	[Native]
	public enum AVAudioUnitEQFilterType : nint {
		Parametric = 0,
		LowPass = 1,
		HighPass = 2,
		ResonantLowPass = 3,
		ResonantHighPass = 4,
		BandPass = 5,
		BandStop = 6,
		LowShelf = 7,
		HighShelf = 8,
		ResonantLowShelf = 9,
		ResonantHighShelf = 10
	}
	
	[Native]
	public enum AVAudioUnitReverbPreset : nint {
		SmallRoom = 0,
		MediumRoom = 1,
		LargeRoom = 2,
		MediumHall = 3,
		LargeHall = 4,
		Plate = 5,
		MediumChamber = 6,
		LargeChamber = 7,
		Cathedral = 8,
		LargeRoom2 = 9,
		MediumHall2 = 10,
		MediumHall3 = 11,
		LargeHall2 = 12
	}

	[Native]
	public enum AVAudioUnitDistortionPreset : nint {
		DrumsBitBrush = 0,
		DrumsBufferBeats = 1,
		DrumsLoFi = 2,
		MultiBrokenSpeaker = 3,
		MultiCellphoneConcert = 4,
		MultiDecimated1 = 5,
		MultiDecimated2 = 6,
		MultiDecimated3 = 7,
		MultiDecimated4 = 8,
		MultiDistortedFunk = 9,
		MultiDistortedCubed = 10,
		MultiDistortedSquared = 11,
		MultiEcho1 = 12,
		MultiEcho2 = 13,
		MultiEchoTight1 = 14,
		MultiEchoTight2 = 15,
		MultiEverythingIsBroken = 16,
		SpeechAlienChatter = 17,
		SpeechCosmicInterference = 18,
		SpeechGoldenPi = 19,
		SpeechRadioTower = 20,
		SpeechWaves = 21
	}

	[Native]
	public enum AVAudioEnvironmentDistanceAttenuationModel : nint {
		Exponential = 1,
		Inverse = 2,
		Linear = 3
	}

	[NoTV]
	[Native]
	public enum AVQueuedSampleBufferRenderingStatus : nint {
		Unknown, Rendering, Failed
	}

	[NoTV]
	[Native]
	public enum AVCaptureVideoStabilizationMode : nint {
		Off, Standard, Cinematic, Auto = -1
	}

	[NoTV]
	[Native]
	public enum AVCaptureAutoFocusSystem : nint {
		None,
		ContrastDetection,
		PhaseDetection
	}

	// Convience enum
	[Flags]
	[iOS (6,0)]
	public enum AVMetadataObjectType : ulong {
		None = 0,

		[iOS (6,0)]
		Face = 1 << 0,

		[iOS(7,0)]
		AztecCode = 1 << 1,

		[iOS(7,0)]
		Code128Code = 1 << 2,

		[iOS(7,0)]
		Code39Code = 1 << 3,

		[iOS(7,0)]
		Code39Mod43Code = 1 << 4,

		[iOS(7,0)]
		Code93Code = 1 << 5,

		[iOS(7,0)]
		EAN13Code = 1 << 6,

		[iOS(7,0)]
		EAN8Code = 1 << 7,

		[iOS(7,0)]
		PDF417Code = 1 << 8,

		[iOS(7,0)]
		QRCode = 1 << 9,

		[iOS(7,0)]
		UPCECode = 1 << 10,

		[iOS (8,0)]
		Interleaved2of5Code = 1 << 11,

		[iOS (8,0)]
		ITF14Code = 1 << 12,

		[iOS (8,0)]
		DataMatrixCode = 1 << 13,
	}

#if !MONOMAC
	[NoTV]
	[iOS (9,0)]
	[Native]
	public enum AVCaptureSessionInterruptionReason : nint {
		VideoDeviceNotAvailableInBackground = 1,
		AudioDeviceInUseByAnotherClient = 2,
		VideoDeviceInUseByAnotherClient = 3,
		VideoDeviceNotAvailableWithMultipleForegroundApps = 4
	}

	[iOS (9,0)]
	[Native]
	public enum AVSpeechSynthesisVoiceQuality : nint {
		Default = 1,
		Enhanced
	}
#endif

	[iOS (9,0), Mac (10,11)]
	[Native]
	public enum AVAudioConverterPrimeMethod : nint {
		Pre = 0,
		Normal = 1,
		None = 2
	}

	[iOS (9,0), Mac (10,11)]
	[Native]
	public enum AVAudioConverterInputStatus : nint {
		HaveData = 0,
		NoDataNow = 1,
		EndOfStream = 2
	}

	[iOS (9,0), Mac (10,11)]
	[Native]
	public enum AVAudioConverterOutputStatus : nint {
		HaveData = 0,
		InputRanDry = 1,
		EndOfStream = 2,
		Error = 3
	}

	[iOS (9,0), Mac (10,11)]
	[Native]
	public enum AVMusicSequenceLoadOptions : nuint {
		PreserveTracks = 0,
		ChannelsToTracks = (1 << 0)
	}
			
#if MONOMAC
	[Mac (10,11)]
	[Native]
	public enum AVMovieWritingOptions : nuint
	{
		AddMovieHeaderToDestination = 0,
		TruncateDestinationToMovieHeaderOnly = (1 << 0)
	}
#endif
}
